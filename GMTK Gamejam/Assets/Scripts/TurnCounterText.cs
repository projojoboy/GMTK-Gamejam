using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TurnCounterText : MonoBehaviour {

    [SerializeField] private Text turnCounterText;

    private void Awake()
    {
        //GameManager.Instance.TurnCounter.TurnCountEvent += OnTurnCount;
    }

    // Use this for initialization
    void Start()
    {
        turnCounterText.text = "";
    }

    void OnTurnCount(int turnCounter)
    {
        turnCounterText.text = "" + turnCounter;
    }
}
