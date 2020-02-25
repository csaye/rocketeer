using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreController : MonoBehaviour
{

public GameObject shop;
public GameObject elevationController;

public Text highscoreText;
public Text highscoreCounter;

private ElevationController elevationControllerScript;

private float highscore;

    void Start()
    {
        elevationControllerScript = elevationController.GetComponent<ElevationController>();
    }


    void Update()
    {
        CheckShow();
        UpdateHighscore();
    }

    private void CheckShow() {
        if (shop.transform.position.y == 24) {
            highscoreText.transform.localPosition = new Vector2(-370, -160);
            highscoreCounter.transform.localPosition = new Vector2(-370, -190);
        } else {
            highscoreText.transform.localPosition = new Vector2(-370, -999);
            highscoreCounter.transform.localPosition = new Vector2(-370, -999);
        }
    }

    private void UpdateHighscore() {
        if (elevationControllerScript.correctedElevation > highscore) {
            highscore = elevationControllerScript.correctedElevation;
        }
        highscoreCounter.text = highscore + "M";
    }
}
