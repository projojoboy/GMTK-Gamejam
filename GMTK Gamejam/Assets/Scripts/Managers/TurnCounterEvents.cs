using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnCounterEvents : MonoBehaviour
{
	public UnityEvent onTurnCountZero;

	private void Start()
	{
		GameManager.Instance.TurnCounter.TurnCountZeroEvent += OnTurnCountZero;
	}

	private void OnTurnCountZero()
	{
		onTurnCountZero.Invoke();
	}
}