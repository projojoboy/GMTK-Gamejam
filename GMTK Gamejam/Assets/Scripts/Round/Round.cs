﻿using UnityEngine;

public class Round : MonoBehaviour
{
	private Timer _timer = new Timer();
	public Timer Timer
	{
		get
		{
			return _timer;
		}
	}

	#region C-Sharp Events
	public delegate void RoundSetupHandler();
	public event RoundSetupHandler RoundSetup;
	public delegate void RoundStartHandler();
	public event RoundStartHandler RoundStart;
	public delegate void RoundEndHandler();
	public event RoundEndHandler RoundEnd;
	#endregion

	private void Awake()
	{
		_timer.Finished += OnSetupTimerFinished;
	}

	public void Starting()
	{
		if (RoundStart != null)
			RoundStart();
	}

	public void Ending()
	{
		if (RoundEnd != null)
			RoundEnd();
	}

	public void Setup()
	{
		if (RoundSetup != null)
			RoundSetup();
	}

	private void OnSetupTimerFinished()
	{
		Starting();
	}
}