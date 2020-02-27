using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

public GameObject rocket;
public GameObject resetDummy;

public GameObject k0, k1, k2, k3, k4, k5, k6, k7, k8, k9;
public GameObject oxx0, oxx1, oxx2, oxx3, oxx4, oxx5, oxx6, oxx7, oxx8, oxx9;
public GameObject xox0, xox1, xox2, xox3, xox4, xox5, xox6, xox7, xox8, xox9;
public GameObject xxo0, xxo1, xxo2, xxo3, xxo4, xxo5, xxo6, xxo7, xxo8, xxo9;

private Rocket rocketScript;

private bool liftOff = false;

    void Start()
    {
        rocketScript = rocket.GetComponent<Rocket>();
    }

    void Update()
    {
        if (!liftOff && resetDummy.activeSelf) {
            CheckLiftOff();
        }

        if (!resetDummy.activeSelf) {
            Reset();
        }

        if (resetDummy.activeSelf && rocketScript.score <= 9999) {
            UpdateScore();
        }
    }

    private void UpdateScore() {
        UpdateThousandsPlace();
        UpdateHundredsPlace();
        UpdateTensPlace();
        UpdateOnesPlace();
    }

    private void UpdateThousandsPlace() {
        if (Mathf.Floor(rocketScript.score / 1000) == 0) {
            k0.SetActive(true);
        } else {
            k0.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score / 1000) == 1) {
            k1.SetActive(true);
        } else {
            k1.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score / 1000) == 2) {
            k2.SetActive(true);
        } else {
            k2.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score / 1000) == 3) {
            k3.SetActive(true);
        } else {
            k3.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score / 1000) == 4) {
            k4.SetActive(true);
        } else {
            k4.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score / 1000) == 5) {
            k5.SetActive(true);
        } else {
            k5.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score / 1000) == 6) {
            k6.SetActive(true);
        } else {
            k6.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score / 1000) == 7) {
            k7.SetActive(true);
        } else {
            k7.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score / 1000) == 8) {
            k8.SetActive(true);
        } else {
            k8.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score / 1000) == 9) {
            k9.SetActive(true);
        } else {
            k9.SetActive(false);
        }
    }

    private void UpdateHundredsPlace() {
        if (Mathf.Floor(rocketScript.score % 1000 / 100) == 0) {
            oxx0.SetActive(true);
        } else {
            oxx0.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score % 1000 / 100) == 1) {
            oxx1.SetActive(true);
        } else {
            oxx1.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score % 1000 / 100) == 2) {
            oxx2.SetActive(true);
        } else {
            oxx2.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score % 1000 / 100) == 3) {
            oxx3.SetActive(true);
        } else {
            oxx3.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score % 1000 / 100) == 4) {
            oxx4.SetActive(true);
        } else {
            oxx4.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score % 1000 / 100) == 5) {
            oxx5.SetActive(true);
        } else {
            oxx5.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score % 1000 / 100) == 6) {
            oxx6.SetActive(true);
        } else {
            oxx6.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score % 1000 / 100) == 7) {
            oxx7.SetActive(true);
        } else {
            oxx7.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score % 1000 / 100) == 8) {
            oxx8.SetActive(true);
        } else {
            oxx8.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score % 1000 / 100) == 9) {
            oxx9.SetActive(true);
        } else {
            oxx9.SetActive(false);
        }
    }

    private void UpdateTensPlace() {
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 0) {
            xox0.SetActive(true);
        } else {
            xox0.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 1) {
            xox1.SetActive(true);
        } else {
            xox1.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 2) {
            xox2.SetActive(true);
        } else {
            xox2.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 3) {
            xox3.SetActive(true);
        } else {
            xox3.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 4) {
            xox4.SetActive(true);
        } else {
            xox4.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 5) {
            xox5.SetActive(true);
        } else {
            xox5.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 6) {
            xox6.SetActive(true);
        } else {
            xox6.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 7) {
            xox7.SetActive(true);
        } else {
            xox7.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 8) {
            xox8.SetActive(true);
        } else {
            xox8.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 9) {
            xox9.SetActive(true);
        } else {
            xox9.SetActive(false);
        }
    }

    private void UpdateOnesPlace() {
        if (Mathf.Floor(rocketScript.score % 10) == 0) {
            xxo0.SetActive(true);
        } else {
            xxo0.SetActive(false);
        }

        if (Mathf.Floor(rocketScript.score % 10) == 1) {
            xxo1.SetActive(true);
        } else {
            xxo1.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 2) {
            xxo2.SetActive(true);
        } else {
            xxo2.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 3) {
            xxo3.SetActive(true);
        } else {
            xxo3.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 4) {
            xxo4.SetActive(true);
        } else {
            xxo4.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 5) {
            xxo5.SetActive(true);
        } else {
            xxo5.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 6) {
            xxo6.SetActive(true);
        } else {
            xxo6.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 7) {
            xxo7.SetActive(true);
        } else {
            xxo7.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 8) {
            xxo8.SetActive(true);
        } else {
            xxo8.SetActive(false);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 9) {
            xxo9.SetActive(true);
        } else {
            xxo9.SetActive(false);
        }
    }

    private void Reset() {
        liftOff = false;
    }

    private void CheckLiftOff() {
        if (Input.GetKeyDown("space")) {
            liftOff = true;
        }
    }

}
