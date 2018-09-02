using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour {

    [Header("4 = Nothing, 0 = left, 1 = Right, 2 = Up, 3 = Down")]
    public int pushDir = 4; // 4 = Nothing, 0 = left, 1 = Right, 2 = Up, 3 = Down

    PlayerMovement pm;
    GameObject player;

	// Use this for initialization
	void Start () {
        if (GameObject.Find("Player"))
        {
            pm = GameObject.Find("Player").GetComponent<PlayerMovement>();
            player = GameObject.Find("Player");
        }
	}
}
