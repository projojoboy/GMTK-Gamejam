using UnityEngine;

public class Round : MonoBehaviour
{
	private Timer _setupTimer = new Timer();
	public Timer SetupTimer
	{
		get
		{
			return _setupTimer;
		}
	}
	private Timer _endTimer = new Timer();
	public Timer EndTimer
	{
		get
		{
			return _endTimer;
		}
	}

	#region C-Sharp Events
	public delegate void RoundSetupHandler();
	public event RoundSetupHandler RoundSetup;
	public delegate void RoundStartHandler();
	public event RoundStartHandler RoundStart;
	public delegate void RoundEndHandler();
	public event RoundEndHandler RoundEnd;
	public delegate void RoundFinishHandler();
	public event RoundFinishHandler RoundFinish;
	#endregion

	private void Awake()
	{
		_setupTimer.Finished += OnSetupTimerFinished;
		_endTimer.Finished += OnEndTimerFinished;
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

	public void Finish()
	{
		if (RoundFinish != null)
			RoundFinish();
	}

	private void OnSetupTimerFinished()
	{
		Starting();
	}

	private void OnEndTimerFinished()
	{
		Finish();
	}
}