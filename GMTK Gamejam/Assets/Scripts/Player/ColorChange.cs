﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    [SerializeField] float duration = 1.5f;
    private float t = 0;

    Renderer render;
    Rigidbody2D rb;
    PlayerController pc;

    private void Start()
    {
        render  = GetComponent<Renderer>();
        rb      = GetComponent<Rigidbody2D>();
        pc      = GetComponent<PlayerController>();
    }

    void Update()
    {
        if (t < 1)
        {
            ColorChangerr();
        }
        else
        {
            pc.KillPlayer();
        }
    }


    void ColorChangerr()
    {
        if (rb.velocity == new Vector2(0, 0))
        {
            if (t < 1)
            {
                t += Time.deltaTime / duration * 2;
            }

        }
        else
        {
            if (t < 1 && t > 0)
            {
                t -= Time.deltaTime / duration / 3;
            }
        }

        render.material.color = Color.Lerp(Color.white, Color.red, t);
    }

	public void Setup()
	{
		t = 0;
	}
}
