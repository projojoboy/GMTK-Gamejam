using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDieEvent : MonoBehaviour
{
	public UnityEvent onPlayerDie;

	private void Awake()
	{
		GameObject.FindObjectOfType<PlayerController>().PlayerDieEvent += OnPlayerDie;
	}

	private void OnPlayerDie()
	{
		onPlayerDie.Invoke();
	}
}