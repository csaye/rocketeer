using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

public GameObject shopScore;
public GameObject resetDummy;
public GameObject achievement5;

public bool godMode = false;

public float sideBounds;
public float rocketJump;
public float score;
public float scoreSpeed;
public float cooldownSpeed;

private float frames;
private float cooldownFramesLeft;
private float cooldownFramesRight;
private float scoreSpeedConstant;
private float flights;

private bool liftOff = false;

private ShopScore shopScoreScript;
private Achievement achievementScript5;

    void Start()
    {
        frames = scoreSpeed;

        scoreSpeedConstant = scoreSpeed;

        shopScoreScript = shopScore.GetComponent<ShopScore>();
        achievementScript5 = achievement5.GetComponent<Achievement>();
    }

    void Update()
    {

        if (!resetDummy.activeSelf) {
            Reset();
        }

        if (!liftOff && resetDummy.activeSelf) {
            CheckLiftOff();
        }

        if (liftOff && resetDummy.activeSelf && transform.position.y == 0) {
            CheckMove();
            CheckCooldown();
            IncrementScore();
        }

        if (godMode && resetDummy.activeSelf) {
            transform.position = new Vector3(23f, transform.position.y);
        }

        CheckScoreSpeed();
    }

    private void CheckLiftOff() {
        if (Input.GetKeyDown("space")) {
            liftOff = true;
            flights++;
            CheckAchievements();
        }
    }

    private void CheckMove() {
        if ((Input.GetKey("a") || Input.GetKey("left")) && transform.position.x - rocketJump >= (sideBounds * -1)) {
            if (cooldownFramesLeft < 0 || (Input.GetKeyDown("a") || Input.GetKeyDown("left"))) {
                transform.position = new Vector2(transform.position.x - rocketJump, transform.position.y);
                cooldownFramesLeft = cooldownSpeed;
            }
        }

        if ((Input.GetKey("d") || Input.GetKey("right")) && transform.position.x + rocketJump <= sideBounds) {
            if (cooldownFramesRight < 0 || (Input.GetKeyDown("d") || Input.GetKeyDown("right"))) {
                transform.position = new Vector2(transform.position.x + rocketJump, transform.position.y);
                cooldownFramesRight = cooldownSpeed;
            }
        }
    }

    private void IncrementScore() {
        if (frames == 0) {
            frames = scoreSpeed;
            if (score < 999) {
                score++;
            }
        }
        frames--;
    }

    private void Reset() {
        liftOff = false;
    }

    private void CheckScoreSpeed() {
        if (shopScoreScript.currentTier <= 1) {
            scoreSpeed = scoreSpeedConstant;
        }
        if (shopScoreScript.currentTier == 2) {
            scoreSpeed = Mathf.Round(scoreSpeedConstant * 0.9f);
        }
        if (shopScoreScript.currentTier == 3) {
            scoreSpeed = Mathf.Round(scoreSpeedConstant * 0.8f);
        }
        if (shopScoreScript.currentTier >= 4) {
            scoreSpeed = Mathf.Round(scoreSpeedConstant * 0.7f);
        }
    }

    private void CheckCooldown() {
        cooldownFramesLeft--;
        cooldownFramesRight--;
    }

    private void CheckAchievements() {
        if (flights >= 10 && !achievementScript5.unlocked) {
            achievementScript5.unlocked = true;
        }
    }
}
