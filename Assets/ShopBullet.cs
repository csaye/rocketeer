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
public GameObject achievements;
public GameObject achievement1;
public GameObject achievement6;
public GameObject achievement7;
public GameObject achievement8;

public float currentTier;

private SpriteRenderer spriteRenderer;

private Rocket rocketScript;
private ShopCoins shopCoinsScript;
private ShopLives shopLivesScript;
private ShopScore shopScoreScript;

private Achievement achievementScript1;
private Achievement achievementScript6;
private Achievement achievementScript7;
private Achievement achievementScript8;

private bool active = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        rocketScript = rocket.GetComponent<Rocket>();
        shopCoinsScript = shopCoins.GetComponent<ShopCoins>();
        shopLivesScript = shopLives.GetComponent<ShopLives>();
        shopScoreScript = shopScore.GetComponent<ShopScore>();
        achievementScript1 = achievement1.GetComponent<Achievement>();
        achievementScript6 = achievement6.GetComponent<Achievement>();
        achievementScript7 = achievement7.GetComponent<Achievement>();
        achievementScript8 = achievement8.GetComponent<Achievement>();
    }

    void Update()
    {

        CheckAchievements();

        if (!active) {
            CheckActive();
        }

        if (active && shop.transform.position.y == 24 && achievements.transform.position.y != 48) {
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
            
            if (!achievementScript1.unlocked) {
                achievementScript1.unlocked = true;
            }
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

    private void CheckAchievements() {
        if ((shopCoinsScript.currentTier >= 2 || shopLivesScript.currentTier >= 2 || shopScoreScript.currentTier >= 2) && !achievementScript6.unlocked) {
            achievementScript6.unlocked = true;
        }
        if ((shopCoinsScript.currentTier >= 4 || shopLivesScript.currentTier >= 4 || shopScoreScript.currentTier >= 4) && !achievementScript7.unlocked) {
            achievementScript7.unlocked = true;
        }
        if ((shopCoinsScript.currentTier >= 4 && shopLivesScript.currentTier >= 4 && shopScoreScript.currentTier >= 2) && !achievementScript8.unlocked) {
            achievementScript8.unlocked = true;
        }
    }
}
