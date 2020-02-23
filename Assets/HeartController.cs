using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{

public GameObject cometController;
public GameObject heart1;
public GameObject heart2;
public GameObject heart3;

private CometController cometControllerScript;

    void Start()
    {
        cometControllerScript = cometController.GetComponent<CometController>();
    }

    void Update()
    {
        UpdateLives();
    }

    private void UpdateLives() {
        if (cometControllerScript.lives == 0) {
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
        }
        if (cometControllerScript.lives == 1) {
            heart1.SetActive(true);
            heart2.SetActive(false);
            heart3.SetActive(false);
        }
        if (cometControllerScript.lives == 2) {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(false);
        }
        if (cometControllerScript.lives >= 3) {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
        }
    }
}
