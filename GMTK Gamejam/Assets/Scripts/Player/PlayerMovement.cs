using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] private float movementSpeed = 5;       // How fast u walk
    [SerializeField] private float jumpForce = 4;           // How much force u add on the jump

    [SerializeField] private int moveDir = 0;               // 0 = Left, 1 = Right, 2 = not moving

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();		
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveDir = 0;
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveDir = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Space)) //REMOVE THIS AFTER TEST... Im gonna forget this...
            moveDir = 2;
    }

    // Update is called once per frame
    void FixedUpdate () {
        Walking();
    }

    private void Walking()
    {
        if (moveDir == 0)
        {
            rb.velocity = new Vector2(-movementSpeed * Time.deltaTime, rb.velocity.y);
        }
        else if (moveDir == 1)
        {
            rb.velocity = new Vector2(movementSpeed * Time.deltaTime, rb.velocity.y);
        }
        else if (moveDir == 2)
        {
            rb.velocity = new Vector2(0, 0);
        }
    }

    private void Jump()
    {

    }
}
