using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBackground : MonoBehaviour
{
    [SerializeField] private Vector2 paralaxEffectMultiplier;

    private Transform cameraTransform;
    private Vector3 lastCameraPosistion;
    private float textureUnitSizeX;
    private float textureUnitSizeY;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosistion = cameraTransform.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture texture = sprite.texture;
        textureUnitSizeX = texture.width / sprite.pixelsPerUnit;
        textureUnitSizeY = texture.height / sprite.pixelsPerUnit;
    }

    private void FixedUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosistion;
        transform.position += new Vector3(deltaMovement.x * paralaxEffectMultiplier.x, deltaMovement.y * paralaxEffectMultiplier.y);
        lastCameraPosistion = cameraTransform.position;

        if(Mathf.Abs (cameraTransform.position.x - transform.position.x) >= textureUnitSizeX)
        {
            float offsettPositionX = (cameraTransform.position.x - transform.position.x) % textureUnitSizeX;
            transform.position = new Vector3(cameraTransform.position.x + offsettPositionX, transform.position.y);
        }

        if (Mathf.Abs(cameraTransform.position.y - transform.position.y) >= textureUnitSizeX)
        {
            float offsettPositionY = (cameraTransform.position.y - transform.position.y) % textureUnitSizeY;
            transform.position = new Vector3(cameraTransform.position.x + offsettPositionY, transform.position.y);
        }
    }
}
