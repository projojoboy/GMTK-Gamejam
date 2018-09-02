using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    float duration = 1.5f;
    private float t = 0;
    bool isReset = false;

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
                t += Time.deltaTime / duration;
            }

        }
        else
        {
            if (t < 1 && t > 0)
            {
                t -= Time.deltaTime / duration;
            }
        }

        render.material.color = Color.Lerp(Color.white, Color.red, t);
    }
}
