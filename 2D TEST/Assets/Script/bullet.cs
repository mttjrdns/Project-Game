using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int bulletSpeed;
    public int bulletDamage = 1;
    public Rigidbody2D rb;

    Transform player, bulletTag;
    float distance;

    void Start()
    {
        rb.velocity = transform.right * bulletSpeed;
    }

    private void FixedUpdate()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        bulletTag = GameObject.FindGameObjectWithTag("Bullet").transform;
        distance = Vector2.Distance(player.transform.position, bulletTag.transform.position);
        if (distance >= 45f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        SoldierHealth soldierHealth = hitInfo.GetComponent<SoldierHealth>();
        if(soldierHealth != null)
        {
            soldierHealth.TakeDamage(bulletDamage);
            Destroy(gameObject);
        }             
    }
}
