using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private static GameManager _instance;
	public static GameManager Instance
	{
		get
		{
			return _instance;
		}
	}

	private Round _round;
	public Round Round
	{
		get
		{
			return _round;
		}
	}

	private void Awake()
	{
		if (_instance == null) _instance = this;

		_round = GetComponent<Round>();
		_round.RoundSetup += OnRoundSetup;
	}

	private void OnRoundSetup()
	{
		_round.Timer.Start(5);
	}

	private void OnPlayerMove()
	{

	}
}