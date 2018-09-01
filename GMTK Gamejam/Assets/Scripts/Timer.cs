using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
	private int _currentSeconds;

	#region C-Sharp Events
	public delegate void TimerFinishHandler();
	public event TimerFinishHandler Finished;
	public delegate void TimerSecondsChangedHandler(int seconds);
	public event TimerSecondsChangedHandler SecondsChanged;
	#endregion

	public void Start(int seconds)
	{
		_currentSeconds = seconds;
		GameObject.FindObjectOfType<MonoBehaviour>().StartCoroutine(Routine(seconds));
	}

	private IEnumerator Routine(int seconds)
	{
		while (_currentSeconds > 0)
		{
			SecondsChanged(_currentSeconds);
			yield return new WaitForSeconds(1);
			_currentSeconds--;
		}
		SecondsChanged(_currentSeconds);
		Finished();
	}
}