using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateComet : MonoBehaviour
{

public Transform comet;

public float bounds;
public float cometFrequency;
public float waitTime;

private float frames;
private float randomX;

private bool liftOff = false;
private bool waitTimeOver = false;

    // Start is called before the first frame update
    void Start()
    {
        frames = cometFrequency;
    }

    // Update is called once per frame
    void Update()
    {
        if (!liftOff) {
            CheckLiftOff();
        }

        if (liftOff && !waitTimeOver) {
            WaitTime();
        }

        if (waitTimeOver) {
            CheckComet();
        }
    }

    private void CheckLiftOff() {
        if (Input.GetKeyDown("space")) {
            liftOff = true;
        }
    }

    private void CheckComet() {
        if (frames == 0) {
            frames = cometFrequency;
            InstantiateComet();
        }
        frames--;
    }

    private void InstantiateComet() {

        randomX = Mathf.Round(Random.Range(((bounds / 2) * -1), (bounds / 2))) * 2;

        Instantiate(comet, new Vector2(randomX, 15), Quaternion.identity);
    }

    private void WaitTime() {
        if (waitTime == 0) {
            waitTimeOver = true;
        }
        waitTime--;
    }

}
