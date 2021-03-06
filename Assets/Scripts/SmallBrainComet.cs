﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBrainComet : MonoBehaviour
{

public GameObject cometController;
public GameObject shopLives;
public GameObject shopMaxLives;
public GameObject rocket;
public GameObject resetDummy;
public GameObject shop;

public bool gameOver = false;

public float startY;
public float bounds;
public float waitTime;
public float cometSpeed;

private bool liftOff = false;
private bool waitTimeOver = false;
private bool collisionRegistered = false;

private float randomX;
private float cometSpeedConstant;
private float waitTimeConstant;

private ShopLives shopLivesScript;
private ShopMaxLives shopMaxLivesScript;
private CometController cometControllerScript;

    void Start()
    {
        randomX = Mathf.Round(Random.Range(((bounds / 2) * -1), (bounds / 2))) * 2;

        transform.position = new Vector2(randomX, transform.position.y);

        cometSpeedConstant = cometSpeed;
        waitTimeConstant = waitTime;

        shopLivesScript = shopLives.GetComponent<ShopLives>();
        shopMaxLivesScript = shopMaxLives.GetComponent<ShopMaxLives>();
        cometControllerScript = cometController.GetComponent<CometController>();
    }

    void Update()
    {

        if (!resetDummy.activeSelf) {
            Reset();
        }

        if (!liftOff && resetDummy.activeSelf) {
            CheckLiftOff();
        }

        if (liftOff & !waitTimeOver && resetDummy.activeSelf) {
            WaitTime();
        }

        if (waitTimeOver && shop.transform.position.y != 24) {
            FadeDown();
            CheckCollide();
            ChangeCometSpeed();
        }
    }

    private void CheckLiftOff() {
        if (Input.GetKeyDown("space")) {
            liftOff = true;
        }
    }

    private void FadeDown() {

        if (transform.position.y < -15) {
            GetComponent<Renderer>().enabled = true;
            randomX = Mathf.Round(Random.Range(((bounds / 2) * -1), (bounds / 2))) * 2;
            transform.position = new Vector2(randomX, 15);
        }

        transform.position = new Vector2(transform.position.x, transform.position.y - cometSpeed);
    }

    private void WaitTime() {
        waitTime--;
        if (waitTime == 0) {
            waitTimeOver = true;
        }
    }

    private void CheckCollide() {
        if (Mathf.Round(transform.position.x) == Mathf.Round(rocket.transform.position.x) && transform.position.y > -10 && transform.position.y < -6 && rocket.transform.position.y == 0 && GetComponent<Renderer>().enabled == true) {
            if (!collisionRegistered) {
                collisionRegistered = true;
                if (cometControllerScript.lives <= 0) {
                    gameOver = true;
                    rocket.transform.position = new Vector2(0, -999);
                } else {
                    cometControllerScript.lives--;
                }
            }
        } else {
            collisionRegistered = false;
        }
    }

    private void ChangeCometSpeed() {
        if (cometSpeed < 0.8f) {
            cometSpeed = cometSpeed + 0.0001f;
        }
    }

    private void Reset() {
        gameOver = false;
        liftOff = false;
        waitTimeOver = false;
        collisionRegistered = false;
        
        waitTime = waitTimeConstant;
        cometSpeed = cometSpeedConstant;

        randomX = Mathf.Round(Random.Range(((bounds / 2) * -1), (bounds / 2))) * 2;
        transform.position = new Vector2(randomX, startY);

        if (shopLivesScript.currentTier <= 1) {
            cometControllerScript.lives = 0;
        }
        if (shopLivesScript.currentTier == 2) {
            cometControllerScript.lives = 1;
        }
        if (shopLivesScript.currentTier == 3) {
            cometControllerScript.lives = 2;
        }
        if (shopLivesScript.currentTier >= 4 && shopMaxLivesScript.currentTier == 1) {
            cometControllerScript.lives = 3;
        }
        if (shopMaxLivesScript.currentTier >= 2) {
            cometControllerScript.lives = 6;
        }

        GetComponent<Renderer>().enabled = true;
    }
}
