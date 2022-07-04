using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40;

    private float horizontalMove;

    bool jump = false;

    public Vector3 smallSize;

    public Vector3 normalSize;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Crouch();
        }
        else
        {
            this.transform.localScale = normalSize;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void Crouch()
    {
        this.transform.localScale = smallSize;
    }
}
