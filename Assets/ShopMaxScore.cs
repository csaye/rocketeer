using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMaxScore : MonoBehaviour
{

public Sprite scoreMaxLight;
public Sprite scoreMaxNormal;
public Sprite scoreOut;

public GameObject shop;
public GameObject rocket;
public GameObject achievements;
public GameObject shopScore;

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
        if (shop.transform.position.y == 24 && achievements.transform.position.y != 48 && shopScore.GetComponent<Renderer>().enabled == false) {
            CheckHighlight();
            GetComponent<Renderer>().enabled = true;
        } else {
            GetComponent<Renderer>().enabled = false;
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
            spriteRenderer.sprite = scoreMaxLight;
        }
        if (currentTier > 1) {
            spriteRenderer.sprite = scoreOut;
        }
    }

    private void Normal() {
        if (currentTier == 1) {
            spriteRenderer.sprite = scoreMaxNormal;
        }
        if (currentTier > 1) {
            spriteRenderer.sprite = scoreOut;
        }
    }

    private void CheckPurchase() {
        if (currentTier == 1 && rocketScript.score >= 1000) {
            rocketScript.score = rocketScript.score - 1000;
            currentTier++;
        }
    }
}
