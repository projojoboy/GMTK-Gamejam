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
	private TurnCounter _turnCounter;
	public TurnCounter TurnCounter
	{
		get
		{
			return _turnCounter;
		}
	}

	private void Awake()
	{
		if (_instance == null) _instance = this;

		_round = GetComponent<Round>();
		_round.RoundSetup += OnRoundSetup;
		_turnCounter = GetComponent<TurnCounter>();
		GameObject.FindObjectOfType<PlayerMovement>().PlayerMoveEvent += OnPlayerMove;
	}

	private void Start()
	{
		_round.Setup();
	}

	private void OnRoundSetup()
	{
		_round.RoundStart += OnRoundStart;
		_round.Timer.Start(5);
	}

	private void OnPlayerMove()
	{
		_turnCounter.TurnUpdater();
	}

	private void OnRoundStart()
	{
		GameObject.FindObjectOfType<PlayerMovement>().enabled = true;
	}
}