using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOutline : MonoBehaviour
{

public GameObject shopCoins;
public GameObject shopLives;
public GameObject shopScore;
public GameObject shopBullet;
public GameObject sColor, hColor, oColor, pColor;

private ShopCoins shopCoinsScript;
private ShopLives shopLivesScript;
private ShopScore shopScoreScript;
private ShopBullet shopBulletScript;

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
}
