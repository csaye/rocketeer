using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBrainComet : MonoBehaviour
{

public GameObject rocket;

public bool gameOver = false;

public float bounds;
public float waitTime;
public float cometSpeed;

private bool liftOff = false;
private bool waitTimeOver = false;

private float randomX;

    void Start()
    {
        randomX = Mathf.Round(Random.Range(((bounds / 2) * -1), (bounds / 2))) * 2;

        transform.position = new Vector2(randomX, transform.position.y);
    }

    void Update()
    {
        if (!liftOff) {
            CheckLiftOff();
        }

        if (liftOff & !waitTimeOver) {
            WaitTime();
        }

        if (waitTimeOver) {
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
            randomX = Mathf.Round(Random.Range(((bounds / 2) * -1), (bounds / 2))) * 2;

            transform.position = new Vector2(randomX, 15);
        }

        transform.position = new Vector2(transform.position.x, transform.position.y - cometSpeed);
    }

    private void WaitTime() {
        if (waitTime == 0) {
            waitTimeOver = true;
        }
        waitTime--;
    }

    private void CheckCollide() {
        if (Mathf.Round(transform.position.x) == Mathf.Round(rocket.transform.position.x) && transform.position.y > -10 && transform.position.y < -6) {
            gameOver = true;

            rocket.transform.position = new Vector2(transform.position.x, -999);
            Debug.Log("game over");
        }
    }

    private void ChangeCometSpeed() {
        if (cometSpeed < 0.8f) {
            cometSpeed = cometSpeed + 0.0001f;
        }
    }
}
