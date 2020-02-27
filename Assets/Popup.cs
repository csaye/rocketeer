using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{

public GameObject achievement;

private Achievement achievementScript;

private bool activated = false;

private float frames = 180;

    void Start()
    {
        achievementScript = achievement.GetComponent<Achievement>();
    }


    void Update()
    {
        if (achievementScript.unlocked && frames > 0) {
            ActivatePopup();
        } else {
            GetComponent<Renderer>().enabled = false;
        }
    }

    private void ActivatePopup() {
        GetComponent<Renderer>().enabled = true;
        frames--;
    }
}
