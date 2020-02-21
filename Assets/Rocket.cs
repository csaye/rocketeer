using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

public bool godMode = false;

public float sideBounds;
public float rocketJump;
public float score;
public float scoreSpeed;

private float frames;

private bool liftOff = false;

public GameObject resetDummy;

    // Start is called before the first frame update
    void Start()
    {
        frames = scoreSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        if (!resetDummy.activeSelf) {
            Reset();
        }

        if (!liftOff && resetDummy.activeSelf) {
            CheckLiftOff();
        }

        if (liftOff && resetDummy.activeSelf && transform.position.y != -999) {
            CheckMove();
            IncrementScore();
        }

        if (godMode && resetDummy.activeSelf) {
            transform.position = new Vector3(23f, transform.position.y);
        }
    }

    private void CheckLiftOff() {
        if (Input.GetKeyDown("space")) {
            liftOff = true;
        }
    }

    private void CheckMove() {
        if ((Input.GetKeyDown("a") || Input.GetKeyDown("left")) && transform.position.x - rocketJump >= (sideBounds * -1)) {
            transform.position = new Vector2(transform.position.x - rocketJump, transform.position.y);
        }

        if ((Input.GetKeyDown("d") || Input.GetKeyDown("right")) && transform.position.x + rocketJump <= sideBounds) {
            transform.position = new Vector2(transform.position.x + rocketJump, transform.position.y);
        }
    }

    private void IncrementScore() {
        if (frames == 0) {
            frames = scoreSpeed;
            score++;
        }
        frames--;
    }

    private void Reset() {
        liftOff = false;
    }

}
