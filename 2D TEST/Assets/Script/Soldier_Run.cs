using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier_Run : StateMachineBehaviour
{
    Transform player;
    Rigidbody2D rb;
    private float runSpeed = 40f;
    private float distance;
    public float attackRange = 3f;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        distance = Vector2.Distance(player.transform.position,rb.transform.position);
       
        if (distance <= 40f)
        {
            Vector2 targetVelocity = new Vector2((runSpeed * Time.fixedDeltaTime) * -10f, rb.velocity.y);
            rb.velocity = targetVelocity;
            //Vector2 target = new Vector2(player.position.x, rb.position.y);
            //Vector2 newPos = Vector2.MoveTowards(rb.position, target, runSpeed * Time.fixedDeltaTime);
            //rb.MovePosition(newPos);
            //Debug.Log(newPos);
          
        }

        if(distance <= attackRange)
        {
            animator.SetTrigger("Attack");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }
}
