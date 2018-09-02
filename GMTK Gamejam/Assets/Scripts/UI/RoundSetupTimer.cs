using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundSetupTimer : MonoBehaviour
{
	[SerializeField] private Text _text;

	private void Awake()
	{
		GameManager.Instance.Round.Timer.SecondsChanged += OnSecondsChanged;
	}

	private void OnSecondsChanged(int seconds)
	{
		_text.text = seconds.ToString();
	}
}