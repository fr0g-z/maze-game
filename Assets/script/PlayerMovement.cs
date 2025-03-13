using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //we put info at start of class
    
    public float speed = 4.5f;
    public float jumpForce = 5;
    public string hero = "Alice";
    

    //xyz cordinates 
    public Vector3 direction;
    public Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("my name is" + hero);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //the dot is there to access a functionality of transform
        //translate means move 

        // transform.Translate(direction * Time.deltaTime * speed);


        Vector3 velocity = direction * speed;
        velocity.y = playerRb.velocity.y;
       
        
        
        playerRb.velocity = velocity;

    }
    private void OnMove(InputValue value)
    {
        //asks the input system what keys are beiong pressed

        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x, 0, inputValue.y);
    }
    private void OnJump(InputValue value)
    {
        //Physics,raycast will cast a line that can hit other colliders, if it finds a collider it returns true if it doesnt it returns false
       bool isGrounded = Physics.Raycast(transform.position,Vector3.down,1.1f); //- jump once mechanic

        if (isGrounded)
        {

           playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
