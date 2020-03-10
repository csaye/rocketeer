using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{

public GameObject shop;
public GameObject rocket;
public GameObject resetDummy;
public GameObject achievements;
public GameObject customize;

public Sprite normal;
public Sprite light;

public float waitTime;

private SpriteRenderer spriteRenderer;

private bool waitTimeOver = false;
private bool restart = false;

private float waitTimeConstant;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        if (spriteRenderer.sprite == null) {
            spriteRenderer.sprite = normal;
        }

        waitTimeConstant = waitTime;
    }


    void Update()
    {

        if (shop.transform.position.y == 24 && achievements.transform.position.y != 48 && customize.transform.position.y != 72) {
            CheckHighlight();
        }

        if (restart && !resetDummy.activeSelf) {
            WaitTime();
            Restart();
        }
    }

    private void CheckHighlight() {
        if (Input.mousePosition.x >= 596.6f && Input.mousePosition.x <= 842.1f &&
        Input.mousePosition.y >= 16.3f && Input.mousePosition.y <= 73.6f) {
            Light();
            if (Input.GetMouseButtonDown(0)) {
                resetDummy.SetActive(false);
                restart = true;
            }
        } else {
            Normal();
        }
    }

    private void Light() {
        spriteRenderer.sprite = light;
    }

    private void Normal() {
        spriteRenderer.sprite = normal;
    }

    private void Restart() {
        resetDummy.SetActive(false);
        if (waitTimeOver) {
            resetDummy.SetActive(true);
            rocket.transform.position = new Vector2(0, 0);
            Reset();
        }
    }

    private void WaitTime() {
        waitTime--;
        if (waitTime == 0) {
            waitTimeOver = true;
        }
    }

    private void Reset() {
        restart = false;
        waitTimeOver = false;
        waitTime = waitTimeConstant;
    }
}
