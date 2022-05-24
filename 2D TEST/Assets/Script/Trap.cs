using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public int trapDamage;

    private void OnCollisionEnter2D(Collision2D touch)
    {
        Player player = touch.gameObject.GetComponent<Player>();
        if(player != null)
        {
            player.TakeDamage(trapDamage);
        }
    }
}
