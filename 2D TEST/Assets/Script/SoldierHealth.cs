using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierHealth : MonoBehaviour
{
    public GameObject deathEffect;
    public int soldierHealth = 1;
    public Animator animator;
    public void TakeDamage(int damage)
    {
        soldierHealth -= damage;
        if (soldierHealth <= 0)
        {
            Die();        
        }
    }

    public void Die()
    {      
        Instantiate (deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
