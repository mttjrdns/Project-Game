using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public Player player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (player.playerArrow > 0)
            {
                Shoot();
                player.playerArrow--;
                Debug.Log(player.playerArrow);
            }
        }
    }

    void Shoot()
    {     
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);           
    }

}
