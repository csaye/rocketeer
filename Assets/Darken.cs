using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darken : MonoBehaviour
{

public GameObject resetDummy;

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

        if (!resetDummy.activeSelf) {
            Reset();
        }

        if (!liftOff && resetDummy.activeSelf) {
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

        color = new Color(brightness, brightness, brightness);
        spriteRenderer.color = color;
            
        brightness = brightness - darkenSpeed;
    }

    private void WaitTime() {
        waitTime--;
        if (waitTime == 0) {
            waitTimeOver = true;
        }
    }

    private void Reset() {
        liftOff = false;
        waitTimeOver = false;
        brightness = 1;
        color = new Color(brightness, brightness, brightness);
        spriteRenderer.color = color;
    }

}
