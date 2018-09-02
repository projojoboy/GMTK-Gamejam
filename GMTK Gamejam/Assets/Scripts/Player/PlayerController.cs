using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public delegate void PlayerDieHandler();
	public event PlayerDieHandler PlayerDieEvent;

	private Vector3 _startPosition;

	private void Awake()
	{
		_startPosition = transform.position;
	}

	public void KillPlayer()
    {
        GetComponent<PlayerMovement>().enabled = false;
		if (PlayerDieEvent != null)
			PlayerDieEvent();
	}

	public void Setup()
	{
		transform.position = _startPosition;
	}
}
