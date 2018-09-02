using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoundEvents : MonoBehaviour
{
	public UnityEvent onRoundSetup;
	public UnityEvent onRoundStart;

	private void Start()
	{
		GameManager.Instance.Round.RoundSetup += OnRoundSetup;
		GameManager.Instance.Round.RoundStart += OnRoundStart;
	}

	private void OnRoundStart()
	{
		onRoundStart.Invoke();
	}

	private void OnRoundSetup()
	{
		onRoundSetup.Invoke();
	}
}