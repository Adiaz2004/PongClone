using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float xMoveSpeed = 0; //Variable for x speed
    public float yMoveSpeed = 0; // cariable for y speed

    private float xBorder = 7.5f; // variable for the border of the game
    private float yBorder = 4.5f; //variable or vertical speed

    //variable for move state
    public bool xMove = true;
    public bool yMove = true;


    // Start is called before the first frame update
    void Start()
    {
        xMoveSpeed = 0.0125f; // declare value for horizontal speed
        yMoveSpeed = 0.0125f; // declare value for vertical speed
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal movement

        if(xMove == true)
        {
            transform.position = new Vector2(transform.position.x + xMoveSpeed, transform.position.y);// move right
        }
        else (yMove == true)
        {
            transform.position = new Vector2(transform.position.x - yMoveSpeed, transform.position.y); //move left
        }

        if (transform.position.x >= xBorder)
        {
            xMove = false; ; //make it go left
        }

        if (trasform.position.x <= - xBorder)
        {
            xMoveSpeed *= -1;
        }

        //Vertical Movement

        transform.position = new vector2(transform.position.x, transform.position.y + xMoveSpeed);
        if(transform.position.y >= yBorder)
        {
            yMoveSpeed *= -1;
        }
        if(transform.positiony <= -yBorder)
        {
            yMoveSpeed *= -1;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) //when a collision happen
    {
        debug.log("hit");
        if (collision.collider.CompareTag("Player"))
        {
            if (xMove == true)
            { 
                xMove = false
            }
            else if (xMove == false)
            {
                xMove = true; 
            }
        }
    }
}
