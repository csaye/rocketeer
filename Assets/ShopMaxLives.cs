using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMaxLives : MonoBehaviour
{

public Sprite livesMaxLight;
public Sprite livesMaxNormal;
public Sprite livesOut;

public GameObject shop;
public GameObject rocket;
public GameObject achievements;
public GameObject shopLives;

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
        if (shop.transform.position.y == 24 && achievements.transform.position.y != 48 && shopLives.GetComponent<Renderer>().enabled == false) {
            CheckHighlight();
            GetComponent<Renderer>().enabled = true;
        } else {
            GetComponent<Renderer>().enabled = false;
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
            spriteRenderer.sprite = livesMaxLight;
        }
        if (currentTier > 1) {
            spriteRenderer.sprite = livesOut;
        }
    }

    private void Normal() {
        if (currentTier == 1) {
            spriteRenderer.sprite = livesMaxNormal;
        }
        if (currentTier > 1) {
            spriteRenderer.sprite = livesOut;
        }
    }

    private void CheckPurchase() {
        if (currentTier == 1 && rocketScript.score >= 1000) {
            rocketScript.score = rocketScript.score - 1000;
            currentTier++;
        }
    }

}
