using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    //Variable for movement
    public float speed = 10f;
    public float yBorder = 4.5f;

    public GameObject right;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
            if (Input.GetKey(KeyCode.O) && transform.position.y < yBorder)    //when O is pressed
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + speed);   //move up
            }

        if (Input.GetKey(KeyCode.L) && transform.position.y > -yBorder)    //when L is pressed
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
            transform.position = new Vector2(transform.position.x, transform.position.y - speed); //move down
        }
    }
}

