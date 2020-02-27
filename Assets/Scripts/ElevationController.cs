using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElevationController : MonoBehaviour
{

public GameObject rocket;
public GameObject resetDummy;
public GameObject coin;
public GameObject achievement2;
public GameObject achievement3;
public GameObject achievement4;

public Text elevationCounter;

private Achievement achievementScript2;
private Achievement achievementScript3;
private Achievement achievementScript4;

public float correctedElevation;

private Coin coinScript;

private bool liftOff = false;

private float elevation;

    void Start()
    {
        coinScript = coin.GetComponent<Coin>();
        achievementScript2 = achievement2.GetComponent<Achievement>();
        achievementScript3 = achievement3.GetComponent<Achievement>();
        achievementScript4 = achievement4.GetComponent<Achievement>();
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
        CheckAchievements();
        elevation = elevation + coinScript.coinSpeed;
    }

    private void CheckAchievements() {
        if (correctedElevation > 5000 && !achievementScript2.unlocked) {
            achievementScript2.unlocked = true;
        }
        if (correctedElevation > 10000 && !achievementScript3.unlocked) {
            achievementScript3.unlocked = true;
        }
        if (correctedElevation > 25000 && !achievementScript4.unlocked) {
            achievementScript4.unlocked = true;
        }
    }
}
