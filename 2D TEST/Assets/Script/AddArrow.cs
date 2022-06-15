using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddArrow : MonoBehaviour
{
    public int arrow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.AddArrow(arrow);
            Destroy(gameObject);
        }
    }
}
