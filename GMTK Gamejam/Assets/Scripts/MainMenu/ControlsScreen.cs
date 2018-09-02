using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsScreen : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	public void AnimateIn()
    {
        anim.Play("AnimateIn");
    }

    public void AnimateOut()
    {
        anim.Play("AnimateOut");
    }
}
