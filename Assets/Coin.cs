using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

public GameObject rocket;
public GameObject resetDummy;
public GameObject shop;
public GameObject comet1, comet2, comet3, comet4, comet5;

public float bounds;
public float waitTime;
public float coinSpeed;
public float coinValue;

private bool liftOff = false;
private bool waitTimeOver = false;
private bool coinCollected = false;

private float randomX;
private float coinSpeedConstant;
private float waitTimeConstant;

private Rocket rocketScript;

    // Start is called before the first frame update
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
    }

    // Update is called once per frame
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
        if (Mathf.Round(transform.position.x) == Mathf.Round(rocket.transform.position.x) && transform.position.y > -10 && transform.position.y < -6 && !coinCollected) {
            coinCollected = true;
            rocketScript.score = rocketScript.score + coinValue;
            transform.position = new Vector2(-999, transform.position.y);
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
}
