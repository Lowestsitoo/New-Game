using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public SoundManagerScript SoundManagerScript;
    public float runSpeed = 40f;
    float horizontalMove = 1f;
    bool jump = false;


    Rigidbody2D rb;





    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {


        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
           
            jump = true;
             SoundManagerScript.PlaySound("Jump");
            


        }
         


    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
  
}