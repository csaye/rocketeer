using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

public GameObject shopCoins;
public GameObject shopMaxCoins;
public GameObject rocket;
public GameObject resetDummy;
public GameObject shop;
public GameObject comet1, comet2, comet3, comet4, comet5;

public float bounds;
public float waitTime;
public float coinSpeed;

private bool liftOff = false;
private bool waitTimeOver = false;
private bool coinCollected = false;

private float randomX;
private float coinSpeedConstant;
private float waitTimeConstant;
private float coinValue = 1;

private Rocket rocketScript;
private ShopCoins shopCoinsScript;
private ShopMaxCoins shopMaxCoinsScript;

    void Start()
    {
        randomX = Mathf.Round(Random.Range(((bounds / 2) * -1), (bounds / 2))) * 2;
        while (randomX == comet1.transform.position.x
        || randomX == comet2.transform.position.x
        || randomX == comet3.transform.position.x
        || randomX == comet4.transform.position.x
        || randomX == comet5.transform.position.x) {
        randomX = Mathf.Round(Random.Range(((bounds / 2) * -1), (bounds / 2))) * 2;
        }

        transform.position = new Vector2(randomX, transform.position.y);

        coinSpeedConstant = coinSpeed;
        waitTimeConstant = waitTime;

        rocketScript = rocket.GetComponent<Rocket>();
        shopCoinsScript = shopCoins.GetComponent<ShopCoins>();
        shopMaxCoinsScript = shopMaxCoins.GetComponent<ShopMaxCoins>();
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
            ChangeCoinSpeed();
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
            while (randomX == comet1.transform.position.x
            || randomX == comet2.transform.position.x
            || randomX == comet3.transform.position.x
            || randomX == comet4.transform.position.x
            || randomX == comet5.transform.position.x) {
            randomX = Mathf.Round(Random.Range(((bounds / 2) * -1), (bounds / 2))) * 2;
            }

            transform.position = new Vector2(randomX, 15);

            coinCollected = false;
        }

        transform.position = new Vector2(transform.position.x, transform.position.y - coinSpeed);
    }

    private void WaitTime() {
        waitTime--;
        if (waitTime == 0) {
            waitTimeOver = true;
        }
    }

    private void CheckCollide() {
        if (Mathf.Round(transform.position.x) == Mathf.Round(rocket.transform.position.x) && transform.position.y > -10 && transform.position.y < -6 && !coinCollected && rocket.transform.position.y == 0) {
            coinCollected = true;
            IncrementScore();
            GetComponent<Renderer>().enabled = false;
        }
    }

    private void ChangeCoinSpeed() {
        if (coinSpeed < 0.8f) {
            coinSpeed = coinSpeed + 0.0001f;
        }
    }

    private void Reset() {
        liftOff = false;
        waitTimeOver = false;
        coinCollected = false;
        
        waitTime = waitTimeConstant;
        coinSpeed = coinSpeedConstant;

        randomX = Mathf.Round(Random.Range(((bounds / 2) * -1), (bounds / 2))) * 2;
        while (randomX == comet1.transform.position.x
        || randomX == comet2.transform.position.x
        || randomX == comet3.transform.position.x
        || randomX == comet4.transform.position.x
        || randomX == comet5.transform.position.x) {
        randomX = Mathf.Round(Random.Range(((bounds / 2) * -1), (bounds / 2))) * 2;
        }

        transform.position = new Vector2(randomX, 15);
    }

    private void IncrementScore() {

        if (shopCoinsScript.currentTier <= 1) {
            coinValue = 1;
        }
        if (shopCoinsScript.currentTier == 2) {
            coinValue = 3;
        }
        if (shopCoinsScript.currentTier == 3) {
            coinValue = 5;
        }
        if (shopCoinsScript.currentTier >= 4 && shopMaxCoinsScript.currentTier == 1) {
            coinValue = 10;
        }
        if (shopMaxCoinsScript.currentTier >= 2) {
            coinValue = 50;
        }

        if (rocketScript.score + coinValue < 9999) {
            rocketScript.score = rocketScript.score + coinValue;
        } else {
            rocketScript.score = 9999;
        }
    }
}
