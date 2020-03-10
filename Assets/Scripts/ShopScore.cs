using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScore : MonoBehaviour
{

public Sprite score1Light;
public Sprite score1Normal;
public Sprite score2Light;
public Sprite score2Normal;
public Sprite score3Light;
public Sprite score3Normal;
public Sprite scoreOut;

public GameObject shop;
public GameObject rocket;
public GameObject achievements;
public GameObject customize;

public float currentTier = 1;

private Rocket rocketScript;

private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        rocketScript = rocket.GetComponent<Rocket>();
    }

    void Update()
    {
        if (shop.transform.position.y == 24 && achievements.transform.position.y != 48) {
            CheckHighlight();
        }
    }

    private void CheckHighlight() {
        if (Input.mousePosition.x >= 634.7f && Input.mousePosition.x <= 681.2f &&
        Input.mousePosition.y >= 184.5f && Input.mousePosition.y <= 231.6f) {
            Light();
            if (Input.GetMouseButtonDown(0)) {
                CheckPurchase();
            }
        } else {
            Normal();
        }
    }

    private void Light() {
        if (currentTier == 1) {
            spriteRenderer.sprite = score1Light;
        }
        if (currentTier == 2) {
            spriteRenderer.sprite = score2Light;
        }
        if (currentTier == 3) {
            spriteRenderer.sprite = score3Light;
        }
        if (currentTier > 3) {
            spriteRenderer.sprite = scoreOut;
        }
    }

    private void Normal() {
        if (currentTier == 1) {
            spriteRenderer.sprite = score1Normal;
        }
        if (currentTier == 2) {
            spriteRenderer.sprite = score2Normal;
        }
        if (currentTier == 3) {
            spriteRenderer.sprite = score3Normal;
        }
        if (currentTier > 3) {
            spriteRenderer.sprite = scoreOut;
        }
    }

    private void CheckPurchase() {
        if (currentTier == 3 && rocketScript.score >= 300) {
            rocketScript.score = rocketScript.score - 300;
            currentTier++;
        }
        if (currentTier == 2 && rocketScript.score >= 200) {
            rocketScript.score = rocketScript.score - 200;
            currentTier++;
        }
        if (currentTier == 1 && rocketScript.score >= 100) {
            rocketScript.score = rocketScript.score - 100;
            currentTier++;
        }
    }
}
