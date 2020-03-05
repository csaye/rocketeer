using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{

public GameObject rocket;
public GameObject resetDummy;
public GameObject shop;
public GameObject cloudA, cloudB, cloudC, cloudD;

public float startY;
public float bounds;
public float waitTime;
public float cloudSpeed;

private bool liftOff = false;
private bool waitTimeOver = false;

private float randomX;
private float cloudSpeedConstant;
private float waitTimeConstant;

    void Start()
    {
        randomX = Random.Range((bounds * -1), bounds);
        while (Mathf.Round(randomX) == Mathf.Round(cloudA.transform.position.x)
            || Mathf.Round(randomX) == Mathf.Round(cloudB.transform.position.x)
            || Mathf.Round(randomX) == Mathf.Round(cloudC.transform.position.x)
            || Mathf.Round(randomX) == Mathf.Round(cloudD.transform.position.x)) {
            randomX = Random.Range((bounds * -1), bounds);
        }

        transform.position = new Vector2(randomX, transform.position.y);

        cloudSpeedConstant = cloudSpeed;
        waitTimeConstant = waitTime;
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
            ChangeCloudSpeed();
        }
    }

    private void CheckLiftOff() {
        if (Input.GetKeyDown("space")) {
            liftOff = true;
        }
    }

    private void FadeDown() {

        if (transform.position.y < -15) {

            randomX = Random.Range((bounds * -1), bounds);
            while (Mathf.Round(randomX) == Mathf.Round(cloudA.transform.position.x)
                || Mathf.Round(randomX) == Mathf.Round(cloudB.transform.position.x)
                || Mathf.Round(randomX) == Mathf.Round(cloudC.transform.position.x)
                || Mathf.Round(randomX) == Mathf.Round(cloudD.transform.position.x)) {
                randomX = Random.Range((bounds * -1), bounds);
            }

            transform.position = new Vector2(randomX, 15);
        }

        transform.position = new Vector2(transform.position.x, transform.position.y - cloudSpeed);
    }

    private void WaitTime() {
        waitTime--;
        if (waitTime == 0) {
            waitTimeOver = true;
        }
    }

    private void ChangeCloudSpeed() {
        if (cloudSpeed < 0.2f) {
            cloudSpeed = cloudSpeed + 0.000025f;
        }
    }

    private void Reset() {
        liftOff = false;
        waitTimeOver = false;
        
        cloudSpeed = cloudSpeedConstant;
        waitTime = waitTimeConstant;

        randomX = Random.Range((bounds * -1), bounds);
        while (Mathf.Round(randomX) == Mathf.Round(cloudA.transform.position.x)
        || Mathf.Round(randomX) == Mathf.Round(cloudB.transform.position.x)
        || Mathf.Round(randomX) == Mathf.Round(cloudC.transform.position.x)
        || Mathf.Round(randomX) == Mathf.Round(cloudD.transform.position.x)) {
        randomX = Random.Range((bounds * -1), bounds);
        }

        transform.position = new Vector2(randomX, startY);
    }
}
