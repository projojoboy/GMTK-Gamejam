using UnityEngine;

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
	#endregion

	private void Awake()
	{
		_timer.Finished += OnSetupTimerFinished;
	}

	public void Starting()
	{
		if (RoundStart != null)
			RoundStart();

		Debug.Log("Round Start");
	}

	public void Setup()
	{
		if (RoundSetup != null)
			RoundSetup();

		Debug.Log("Round Setup");
	}

	private void OnSetupTimerFinished()
	{
		Starting();
	}
}