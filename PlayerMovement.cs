using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    public CharacterController2D controller;
    public float runSpeed = 200f;
    public Animator animator;
    float horizontalmove;
    bool jump = false;
    bool crouch = false;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs(horizontalmove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJump", true);
        }

        if (Input.GetButtonDown("Vertical"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Vertical"))
        {
            crouch = false;
        }
    }

    public void onLanding()
    {
        animator.SetBool("isJump", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalmove * Time.fixedDeltaTime, crouch, jump);
        jump = false; 
    }
}