using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnRoundStart : MonoBehaviour
{
	private void Start()
	{
		GameManager.Instance.Round.RoundStart += OnRoundStart;
	}

	private void OnRoundStart()
	{
		Destroy(gameObject);
	}
}