using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FinishEvents : MonoBehaviour
{
	public UnityEvent onFinish;

	private void Start()
	{
		GameObject.FindObjectOfType<Finish>().FinishEvent += OnFinish;
	}

	private void OnFinish()
	{
		onFinish.Invoke();
	}
}