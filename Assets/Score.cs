using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

public GameObject rocket;

public GameObject oxx0, oxx1, oxx2, oxx3, oxx4, oxx5, oxx6, oxx7, oxx8, oxx9;
public GameObject xox0, xox1, xox2, xox3, xox4, xox5, xox6, xox7, xox8, xox9;
public GameObject xxo0, xxo1, xxo2, xxo3, xxo4, xxo5, xxo6, xxo7, xxo8, xxo9;

private Rocket rocketScript;

    void Start()
    {
        rocketScript = rocket.GetComponent<Rocket>();
    }

    void Update()
    {
        if (rocket.transform.position.y != -999) {
            UpdateScore();
        }
    }

    private void UpdateScore() {
        UpdateHundredsPlace();
        UpdateTensPlace();
        UpdateOnesPlace();
    }

    private void UpdateHundredsPlace() {
        if (Mathf.Floor(rocketScript.score / 100) == 0) {
            oxx0.transform.position = new Vector2(oxx0.transform.position.x, 9.5f);
        } else {
            oxx0.transform.position = new Vector2(oxx0.transform.position.x, -999);
        }

        if (Mathf.Floor(rocketScript.score / 100) == 1) {
            oxx1.transform.position = new Vector2(oxx1.transform.position.x, 9.5f);
        } else {
            oxx1.transform.position = new Vector2(oxx1.transform.position.x, -999);
        }

        if (Mathf.Floor(rocketScript.score / 100) == 2) {
            oxx2.transform.position = new Vector2(oxx2.transform.position.x, 9.5f);
        } else {
            oxx2.transform.position = new Vector2(oxx2.transform.position.x, -999);
        }

        if (Mathf.Floor(rocketScript.score / 100) == 3) {
            oxx3.transform.position = new Vector2(oxx3.transform.position.x, 9.5f);
        } else {
            oxx3.transform.position = new Vector2(oxx3.transform.position.x, -999);
        }

        if (Mathf.Floor(rocketScript.score / 100) == 4) {
            oxx4.transform.position = new Vector2(oxx4.transform.position.x, 9.5f);
        } else {
            oxx4.transform.position = new Vector2(oxx4.transform.position.x, -999);
        }

        if (Mathf.Floor(rocketScript.score / 100) == 5) {
            oxx5.transform.position = new Vector2(oxx5.transform.position.x, 9.5f);
        } else {
            oxx5.transform.position = new Vector2(oxx5.transform.position.x, -999);
        }

        if (Mathf.Floor(rocketScript.score / 100) == 6) {
            oxx6.transform.position = new Vector2(oxx6.transform.position.x, 9.5f);
        } else {
            oxx6.transform.position = new Vector2(oxx6.transform.position.x, -999);
        }

        if (Mathf.Floor(rocketScript.score / 100) == 7) {
            oxx7.transform.position = new Vector2(oxx7.transform.position.x, 9.5f);
        } else {
            oxx7.transform.position = new Vector2(oxx7.transform.position.x, -999);
        }

        if (Mathf.Floor(rocketScript.score / 100) == 8) {
            oxx8.transform.position = new Vector2(oxx8.transform.position.x, 9.5f);
        } else {
            oxx8.transform.position = new Vector2(oxx8.transform.position.x, -999);
        }

        if (Mathf.Floor(rocketScript.score / 100) == 9) {
            oxx9.transform.position = new Vector2(oxx9.transform.position.x, 9.5f);
        } else {
            oxx9.transform.position = new Vector2(oxx9.transform.position.x, -999);
        }
    }

    private void UpdateTensPlace() {
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 0) {
            xox0.transform.position = new Vector2(xox0.transform.position.x, 9.5f);
        } else {
            xox0.transform.position = new Vector2(xox0.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 1) {
            xox1.transform.position = new Vector2(xox1.transform.position.x, 9.5f);
        } else {
            xox1.transform.position = new Vector2(xox1.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 2) {
            xox2.transform.position = new Vector2(xox2.transform.position.x, 9.5f);
        } else {
            xox2.transform.position = new Vector2(xox2.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 3) {
            xox3.transform.position = new Vector2(xox3.transform.position.x, 9.5f);
        } else {
            xox3.transform.position = new Vector2(xox3.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 4) {
            xox4.transform.position = new Vector2(xox4.transform.position.x, 9.5f);
        } else {
            xox4.transform.position = new Vector2(xox4.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 5) {
            xox5.transform.position = new Vector2(xox5.transform.position.x, 9.5f);
        } else {
            xox5.transform.position = new Vector2(xox5.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 6) {
            xox6.transform.position = new Vector2(xox6.transform.position.x, 9.5f);
        } else {
            xox6.transform.position = new Vector2(xox6.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 7) {
            xox7.transform.position = new Vector2(xox7.transform.position.x, 9.5f);
        } else {
            xox7.transform.position = new Vector2(xox7.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 8) {
            xox8.transform.position = new Vector2(xox8.transform.position.x, 9.5f);
        } else {
            xox8.transform.position = new Vector2(xox8.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 100 / 10) == 9) {
            xox9.transform.position = new Vector2(xox9.transform.position.x, 9.5f);
        } else {
            xox9.transform.position = new Vector2(xox9.transform.position.x, -999);
        }
    }

    private void UpdateOnesPlace() {
        if (Mathf.Floor(rocketScript.score % 10) == 0) {
            xxo0.transform.position = new Vector2(xxo0.transform.position.x, 9.5f);
        } else {
            xxo0.transform.position = new Vector2(xxo0.transform.position.x, -999);
        }

        if (Mathf.Floor(rocketScript.score % 10) == 1) {
            xxo1.transform.position = new Vector2(xxo1.transform.position.x, 9.5f);
        } else {
            xxo1.transform.position = new Vector2(xxo1.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 2) {
            xxo2.transform.position = new Vector2(xxo2.transform.position.x, 9.5f);
        } else {
            xxo2.transform.position = new Vector2(xxo2.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 3) {
            xxo3.transform.position = new Vector2(xxo3.transform.position.x, 9.5f);
        } else {
            xxo3.transform.position = new Vector2(xxo3.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 4) {
            xxo4.transform.position = new Vector2(xxo4.transform.position.x, 9.5f);
        } else {
            xxo4.transform.position = new Vector2(xxo4.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 5) {
            xxo5.transform.position = new Vector2(xxo5.transform.position.x, 9.5f);
        } else {
            xxo5.transform.position = new Vector2(xxo5.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 6) {
            xxo6.transform.position = new Vector2(xxo6.transform.position.x, 9.5f);
        } else {
            xxo6.transform.position = new Vector2(xxo6.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 7) {
            xxo7.transform.position = new Vector2(xxo7.transform.position.x, 9.5f);
        } else {
            xxo7.transform.position = new Vector2(xxo7.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 8) {
            xxo8.transform.position = new Vector2(xxo8.transform.position.x, 9.5f);
        } else {
            xxo8.transform.position = new Vector2(xxo8.transform.position.x, -999);
        }
        
        if (Mathf.Floor(rocketScript.score % 10) == 9) {
            xxo9.transform.position = new Vector2(xxo9.transform.position.x, 9.5f);
        } else {
            xxo9.transform.position = new Vector2(xxo9.transform.position.x, -999);
        }
    }

}
