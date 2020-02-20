using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darken : MonoBehaviour
{

public float darkenSpeed;
public float waitTime;

private bool liftOff = false;
private bool waitTimeOver = false;

private float brightness = 1;

private SpriteRenderer spriteRenderer;

private Color color = new Color(1, 1, 1);

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        if (!liftOff) {
            CheckLiftOff();
        }

        if (liftOff && !waitTimeOver) {
            WaitTime();
        }

        if (waitTimeOver && brightness > 0.2f) {
            DarkenSky();
        }
    }

    private void CheckLiftOff() {
        if (Input.GetKeyDown("space")) {
            liftOff = true;
        }
    }

    private void DarkenSky() {
        Debug.Log(brightness);

        color = new Color(brightness, brightness, brightness);
        spriteRenderer.color = color;
            
        brightness = brightness - darkenSpeed;
    }

    private void WaitTime() {
        if (waitTime == 0) {
            waitTimeOver = true;
        }
        waitTime--;
    }

}
