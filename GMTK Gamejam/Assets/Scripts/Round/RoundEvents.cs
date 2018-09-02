using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RoundEvents : MonoBehaviour
{
	public UnityEvent onRoundSetup;
	public UnityEvent onRoundStart;
	public UnityEvent onRoundEnd;
	public UnityEvent onRoundFinish;

	private void Start()
	{
		GameManager.Instance.Round.RoundSetup += OnRoundSetup;
		GameManager.Instance.Round.RoundStart += OnRoundStart;
		GameManager.Instance.Round.RoundEnd += OnRoundEnd;
		GameManager.Instance.Round.RoundFinish += OnRoundFinish;
	}

	private void OnRoundSetup()
	{
		onRoundSetup.Invoke();
	}

	private void OnRoundStart()
	{
		onRoundStart.Invoke();
	}

	private void OnRoundEnd()
	{
		onRoundEnd.Invoke();
	}

	private void OnRoundFinish()
	{
		Debug.Log("FINISH");
		onRoundFinish.Invoke();
	}
}