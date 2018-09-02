using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TurnCounter : MonoBehaviour {

    public delegate void TurnCounterHandler(int turnCounter);
    public event TurnCounterHandler TurnCountEvent;
	public delegate void TurnCounterZeroHandler();
	public event TurnCounterZeroHandler TurnCountZeroEvent;

	public int turnCounter;

	private int _currentTurnCounter;

    private void Start()
    {
		_currentTurnCounter = turnCounter;

		if (TurnCountEvent != null)
			TurnCountEvent(_currentTurnCounter);    
    }

    public void TurnUpdater()
    {
		if (_currentTurnCounter > 0)
			_currentTurnCounter--;

		if (_currentTurnCounter <= 0)
			TurnCountZeroEvent();

		if (TurnCountEvent != null)
			TurnCountEvent(_currentTurnCounter);
    }

	public void Setup()
	{
		_currentTurnCounter = turnCounter;

		if (TurnCountEvent != null)
			TurnCountEvent(_currentTurnCounter);
	}
}
