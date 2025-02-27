using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //we put info at start of class
    public int health = 100;
    public float speed = 4.5f;
    public string hero = "Alice";
    public bool isAlive = true;

    //xyz cordinates 
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("my name is" + hero);
    }

    // Update is called once per frame
    void Update()
    {
        //the dot is there to access a functionality of transform
        //translate means move 

        transform.Translate(direction * Time.deltaTime * speed);

    }
    private void OnMove(InputValue value)
    {
        //asks the input system what keys are beiong pressed

        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x, 0, inputValue.y);
    }
}
