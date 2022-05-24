using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierWeapon : MonoBehaviour
{
    public Vector3 attackOffset;
    public float attackRange = 3f;
    public LayerMask attackMask;
    public int attackDamage = 1;

    public void Attack()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.y;

        Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
        if(colInfo != null)
        {
            colInfo.GetComponent<Player>().TakeDamage(attackDamage);
        }
    }
}
