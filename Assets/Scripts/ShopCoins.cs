using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopCoins : MonoBehaviour
{

public Sprite coins1Light;
public Sprite coins1Normal;
public Sprite coins2Light;
public Sprite coins2Normal;
public Sprite coins3Light;
public Sprite coins3Normal;
public Sprite coinsOut;

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
        if (shop.transform.position.y == 24 && achievements.transform.position.y != 48 && customize.transform.position.y != 72) {
            CheckHighlight();
        }
    }

    private void CheckHighlight() {
        if (Input.mousePosition.x >= 181.1f && Input.mousePosition.x <= 227.6f &&
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
            spriteRenderer.sprite = coins1Light;
        }
        if (currentTier == 2) {
            spriteRenderer.sprite = coins2Light;
        }
        if (currentTier == 3) {
            spriteRenderer.sprite = coins3Light;
        }
        if (currentTier > 3) {
            spriteRenderer.sprite = coinsOut;
        }
    }

    private void Normal() {
        if (currentTier == 1) {
            spriteRenderer.sprite = coins1Normal;
        }
        if (currentTier == 2) {
            spriteRenderer.sprite = coins2Normal;
        }
        if (currentTier == 3) {
            spriteRenderer.sprite = coins3Normal;
        }
        if (currentTier > 3) {
            spriteRenderer.sprite = coinsOut;
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
