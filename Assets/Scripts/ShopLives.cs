using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopLives : MonoBehaviour
{

public Sprite lives1Light;
public Sprite lives1Normal;
public Sprite lives2Light;
public Sprite lives2Normal;
public Sprite lives3Light;
public Sprite lives3Normal;
public Sprite livesOut;

public GameObject shop;
public GameObject rocket;
public GameObject achievements;

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
        if (Input.mousePosition.x >= 407.7f && Input.mousePosition.x <= 454.2f &&
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
            spriteRenderer.sprite = lives1Light;
        }
        if (currentTier == 2) {
            spriteRenderer.sprite = lives2Light;
        }
        if (currentTier == 3) {
            spriteRenderer.sprite = lives3Light;
        }
        if (currentTier > 3) {
            spriteRenderer.sprite = livesOut;
        }
    }

    private void Normal() {
        if (currentTier == 1) {
            spriteRenderer.sprite = lives1Normal;
        }
        if (currentTier == 2) {
            spriteRenderer.sprite = lives2Normal;
        }
        if (currentTier == 3) {
            spriteRenderer.sprite = lives3Normal;
        }
        if (currentTier > 3) {
            spriteRenderer.sprite = livesOut;
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
