using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 60f;
    public Animator animator;
    //float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", runSpeed);
        if (controller.m_Grounded)
        {
            controller.extraJumpsValue = 0;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (controller.m_Grounded)
            {
                jump = true;
            } 
            else 
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {  
                    if (controller.extraJumpsValue < controller.extraJumps)
                    {
                        jump = true;
                        controller.extraJumpsValue++;
                    }
                }
            }
        }
       

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            crouch = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            crouch = false;
        }

        //Animasi di udara
        if (controller.m_Grounded == false)
        {
            if (crouch == true)
            {
                animator.SetBool("isJump", false);
            }
            else
            {
                animator.SetBool("isJump", true);
            }
        }
    }

    public void onLanding()
    {
        animator.SetBool("isJump", false);
    }

    public void onCrouching(bool isCrouch)
    {
        animator.SetBool("isCrouch", isCrouch);     
    }

    void FixedUpdate()
    {
        controller.Move(runSpeed * Time.fixedDeltaTime, jump, crouch);
        jump = false;
    }
}
