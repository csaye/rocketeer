using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBullet : MonoBehaviour
{

public Sprite bulletLight;
public Sprite bulletNormal;
public Sprite bulletOut;

public GameObject shop;
public GameObject rocket;
public GameObject priceBullet;
public GameObject shopCoins;
public GameObject shopLives;
public GameObject shopScore;

public float currentTier;

private SpriteRenderer spriteRenderer;

private Rocket rocketScript;
private ShopCoins shopCoinsScript;
private ShopLives shopLivesScript;
private ShopScore shopScoreScript;

private bool active = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        rocketScript = rocket.GetComponent<Rocket>();
        shopCoinsScript = shopCoins.GetComponent<ShopCoins>();
        shopLivesScript = shopLives.GetComponent<ShopLives>();
        shopScoreScript = shopScore.GetComponent<ShopScore>();
    }

    void Update()
    {

        if (!active) {
            CheckActive();
        }

        if (active && shop.transform.position.y == 24) {
            CheckHighlight();
        }

        if (shop.transform.position.y != 24) {
            SetInactive();
        }
    }

    private void CheckHighlight() {
        if (Input.mousePosition.x >= 407.7f && Input.mousePosition.x <= 454.2f &&
        Input.mousePosition.y >= 58.8f && Input.mousePosition.y <= 102.9f) {
            Light();
            if (Input.GetMouseButtonDown(0)) {
                CheckPurchase();
            }
        } else {
            Normal();
        }
    }

    private void Light() {
        if (currentTier == 0) {
            spriteRenderer.sprite = bulletLight;
        }
        if (currentTier >= 1) {
            spriteRenderer.sprite = bulletOut;
        }
    }

    private void Normal() {
        if (currentTier == 0) {
            spriteRenderer.sprite = bulletNormal;
        }
        if (currentTier >= 1) {
            spriteRenderer.sprite = bulletOut;
        }
    }

    private void CheckPurchase() {
        if (currentTier == 0 && rocketScript.score >= 500) {
            rocketScript.score = rocketScript.score - 500;
            currentTier++;
        }
    }

    private void CheckActive() {
        if (shopCoinsScript.currentTier >= 4 || shopLivesScript.currentTier >= 4 || shopScoreScript.currentTier >= 4) {
            SetActive();
        } else {
            SetInactive();
        }
    }

    private void SetActive() {
        active = true;
        GetComponent<Renderer>().enabled = true;
        priceBullet.GetComponent<Renderer>().enabled = true;
    }

    private void SetInactive() {
        active = false;
        GetComponent<Renderer>().enabled = false;
        priceBullet.GetComponent<Renderer>().enabled = false;
    }
}
