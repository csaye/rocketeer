using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMaxCoins : MonoBehaviour
{

public Sprite coinsMaxLight;
public Sprite coinsMaxNormal;
public Sprite coinsOut;

public GameObject shop;
public GameObject rocket;
public GameObject achievements;
public GameObject customize;
public GameObject shopCoins;

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
        if (shop.transform.position.y == 24 && achievements.transform.position.y != 48 && customize.transform.position.y != 72 && shopCoins.GetComponent<Renderer>().enabled == false) {
            CheckHighlight();
            GetComponent<Renderer>().enabled = true;
        } else {
            GetComponent<Renderer>().enabled = false;
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
            spriteRenderer.sprite = coinsMaxLight;
        }
        if (currentTier > 1) {
            spriteRenderer.sprite = coinsOut;
        }
    }

    private void Normal() {
        if (currentTier == 1) {
            spriteRenderer.sprite = coinsMaxNormal;
        }
        if (currentTier > 1) {
            spriteRenderer.sprite = coinsOut;
        }
    }

    private void CheckPurchase() {
        if (currentTier == 1 && rocketScript.score >= 1000) {
            rocketScript.score = rocketScript.score - 1000;
            currentTier++;
        }
    }
}
