using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElevationController : MonoBehaviour
{

public GameObject rocket;
public GameObject resetDummy;
public GameObject coin;
public Text elevationCounter;

public float correctedElevation;

private Coin coinScript;

private bool liftOff = false;

private float elevation;

    void Start()
    {
        coinScript = coin.GetComponent<Coin>();
    }

    void Update()
    {
        if (!liftOff && resetDummy.activeSelf) {
            CheckLiftOff();
        }

        if (!resetDummy.activeSelf) {
            Reset();
        }

        if (liftOff && resetDummy.activeSelf && rocket.transform.position.y == 0) {
            UpdateElevation();
        }
    }

    private void CheckLiftOff() {
        if (Input.GetKeyDown("space")) {
            liftOff = true;
        }
    }

    private void Reset() {
        liftOff = false;
        elevation = 0;
        elevationCounter.text = 0 + "M"; 
    }

    private void UpdateElevation() {
        correctedElevation = Mathf.Round(elevation * 10); 
        elevationCounter.text = correctedElevation + "M"; 
        elevation = elevation + coinScript.coinSpeed;
    }
}
