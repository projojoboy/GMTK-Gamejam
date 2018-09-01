using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public delegate void PlayerMoveHandler();
    public event PlayerMoveHandler PlayerMoveEvent;

    [SerializeField] private float movementSpeed = 5;       // How fast u walk

    [SerializeField] private int moveDir = 4;               // 0 = Left, 1 = Right, 2 = Up, 3 = Down,  4 = not moving

    Rigidbody2D rb;
    PlayerController pc;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        pc = GetComponent<PlayerController>();
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveDir = 0;
            PlayerMoveEvent();
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveDir = 1;
            PlayerMoveEvent();
        }
        else if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveDir = 2;
            PlayerMoveEvent();
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveDir = 3;
            PlayerMoveEvent();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) //REMOVE THIS AFTER TEST... Im gonna forget this...
            moveDir = 4;
    }

    // Update is called once per frame
    void FixedUpdate () {
        Movement();
    }

    private void Movement()
    {
        // WALKING
        if (moveDir == 0)
        {
            rb.velocity = new Vector2(-movementSpeed * Time.deltaTime, 0);
        }
        else if (moveDir == 1)
        {
            rb.velocity = new Vector2(movementSpeed * Time.deltaTime, 0);
        }
        else if (moveDir == 2)
        {
            rb.velocity = new Vector2(0, movementSpeed * Time.deltaTime);
        }
        else if (moveDir == 3)
        {
            rb.velocity = new Vector2(0, -movementSpeed * Time.deltaTime);
        }
        else if (moveDir == 4)
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
