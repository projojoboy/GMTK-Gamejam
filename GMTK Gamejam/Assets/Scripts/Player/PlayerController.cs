using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public void KillPlayer()
    {
        Debug.Log("U DEAD BRUV");
        GetComponent<PlayerMovement>().enabled = false;
    }
}
