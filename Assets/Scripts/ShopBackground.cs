using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBackground : MonoBehaviour
{

public GameObject rocket;
public GameObject resetDummy;

public float waitTime;

private float waitTimeConstant;

private bool waitTimeOver;

    // Start is called before the first frame update
    void Start()
    {
        waitTimeConstant = waitTime;
    }

    // Update is called once per frame
    void Update()
    {

        if (!resetDummy.activeSelf) {
            Reset();
        }

        if (rocket.transform.position.y == -999 && !waitTimeOver) {
            WaitTime();
        }

        if (rocket.transform.position.y == -999 && waitTimeOver) {
            ShowMenu();
        } else {
            HideMenu();
        }
    }

    private void ShowMenu() {
        transform.position = new Vector2(0, 24);
    }

    private void HideMenu() {
        transform.position = new Vector2(0, 0);
    }

    private void WaitTime() {
        waitTime--;
        if (waitTime == 0) {
            waitTimeOver = true;
        }
    }

    private void Reset() {
        waitTimeOver = false;
        waitTime = waitTimeConstant;
    }
}
