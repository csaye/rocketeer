using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopOutline : MonoBehaviour
{

public GameObject shopCoins;
public GameObject shopLives;
public GameObject shopScore;
public GameObject shopBullet;
public GameObject shop;
public GameObject sColor, hColor, oColor, pColor;
public GameObject coinsText, livesText, scoreText;
public GameObject coinsPrice, livesPrice, scorePrice, bulletPrice;

private ShopCoins shopCoinsScript;
private ShopLives shopLivesScript;
private ShopScore shopScoreScript;
private ShopBullet shopBulletScript;

private bool hidden = false;

    void Start()
    {
        shopCoinsScript = shopCoins.GetComponent<ShopCoins>();
        shopLivesScript = shopLives.GetComponent<ShopLives>();
        shopScoreScript = shopScore.GetComponent<ShopScore>();
        shopBulletScript = shopBullet.GetComponent<ShopBullet>();
    }

    void Update()
    {
        CheckShow();
        CheckHide();
        if (hidden) {
            HideAll();
        }
    }

    private void CheckShow() {
        if (shopCoinsScript.currentTier >= 4) {
            sColor.GetComponent<Renderer>().enabled = true;
        } else {
            sColor.GetComponent<Renderer>().enabled = false;
        }
        if (shopLivesScript.currentTier >= 4) {
            hColor.GetComponent<Renderer>().enabled = true;
        } else {
            hColor.GetComponent<Renderer>().enabled = false;
        }
        if (shopScoreScript.currentTier >= 4) {
            oColor.GetComponent<Renderer>().enabled = true;
        } else {
            oColor.GetComponent<Renderer>().enabled = false;
        }
        if (shopBulletScript.currentTier >= 1) {
            pColor.GetComponent<Renderer>().enabled = true;
        } else {
            pColor.GetComponent<Renderer>().enabled = false;
        }
    }

    private void CheckHide() {
        if (sColor.GetComponent<Renderer>().enabled == true
        && hColor.GetComponent<Renderer>().enabled == true
        && oColor.GetComponent<Renderer>().enabled == true
        && pColor.GetComponent<Renderer>().enabled == true
        && shop.transform.position.y == 0) {
            hidden = true;
        }
    }

    private void HideAll() {
        shopCoins.GetComponent<Renderer>().enabled = false;
        shopLives.GetComponent<Renderer>().enabled = false;
        shopScore.GetComponent<Renderer>().enabled = false;
        shopBullet.GetComponent<Renderer>().enabled = false;

        coinsText.GetComponent<Renderer>().enabled = false;
        livesText.GetComponent<Renderer>().enabled = false;
        scoreText.GetComponent<Renderer>().enabled = false;
        
        coinsPrice.GetComponent<Renderer>().enabled = false;
        livesPrice.GetComponent<Renderer>().enabled = false;
        scorePrice.GetComponent<Renderer>().enabled = false;
        bulletPrice.GetComponent<Renderer>().enabled = false;
    }
}
