using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TurnCounterText : MonoBehaviour {

    [SerializeField] private Text turnCounterText;

    private void Start()
    {
        GameManager.Instance.TurnCounter.TurnCountEvent += OnTurnCount;
    }

    void OnTurnCount(int turnCounter)
    {
        turnCounterText.text = "" + turnCounter;
    }
}
