using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public delegate void PlayerMoveHandler();
    public event PlayerMoveHandler PlayerMoveEvent;

    [SerializeField] private float movementSpeed = 5;       // How fast u walk

    [SerializeField] public int moveDir = 4;               // 0 = Left, 1 = Right, 2 = Up, 3 = Down,  4 = not moving

	private int _currentMoveDir;
	private bool _inputEnabled = true;

	Rigidbody2D rb;
    PlayerController pc;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        pc = GetComponent<PlayerController>();

		_currentMoveDir = moveDir;
	}

    private void Update()
    {
		if (!_inputEnabled) return;

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) && _currentMoveDir != 0)
        {
			_currentMoveDir = 0;
			if (PlayerMoveEvent != null)
				PlayerMoveEvent();
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) && _currentMoveDir != 1)
        {
			_currentMoveDir = 1;
			if (PlayerMoveEvent != null)
				PlayerMoveEvent();
        }
        else if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && _currentMoveDir != 2)
        {
			_currentMoveDir = 2;
			if (PlayerMoveEvent != null)
				PlayerMoveEvent();
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) && _currentMoveDir != 3)
        {
			_currentMoveDir = 3;
			if (PlayerMoveEvent != null)
				PlayerMoveEvent();
        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        Movement();
    }

    private void Movement()
    {
        // WALKING
        if (_currentMoveDir == 0)
        {
            rb.velocity = new Vector2(-movementSpeed * Time.deltaTime, 0);
        }
        else if (_currentMoveDir == 1)
        {
            rb.velocity = new Vector2(movementSpeed * Time.deltaTime, 0);
        }
        else if (_currentMoveDir == 2)
        {
            rb.velocity = new Vector2(0, movementSpeed * Time.deltaTime);
        }
        else if (_currentMoveDir == 3)
        {
            rb.velocity = new Vector2(0, -movementSpeed * Time.deltaTime);
        }
        else if (_currentMoveDir == 4)
        {
            rb.velocity = new Vector2(0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "MoveWall")
        {
			_currentMoveDir = coll.GetComponent<WallController>().pushDir;
        }
    }

	public void Setup()
	{
		_currentMoveDir = moveDir;
		_inputEnabled = true;
	}

	public void DisableInput()
	{
		_inputEnabled = false;
		_currentMoveDir = 4;
	}
}
