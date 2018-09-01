using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TurnCounter : MonoBehaviour {

    public delegate void TurnCounterHandler(int turnCounter);
    public event TurnCounterHandler TurnCountEvent;

    public int turnCounter;

    private void Start()
    {
        TurnCountEvent(turnCounter);    
    }

    public void TurnUpdater()
    {
        turnCounter--;
        TurnCountEvent(turnCounter);

        if (turnCounter <= 0)
            Dead();
    }

    void Dead()
    {
        Debug.Log("U dead bruv");
    }
}
