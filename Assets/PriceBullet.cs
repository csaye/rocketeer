using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceBullet : MonoBehaviour
{

public GameObject shopBullet;
public GameObject shop;

public Sprite price500;
public Sprite priceOut;

private ShopBullet shopBulletScript;

private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        shopBulletScript = shopBullet.GetComponent<ShopBullet>();
    }

    void Update()
    {
        if (shop.transform.position.y == 24) {
            CheckPrice();
        }
    }

    private void CheckPrice() {
        if (shopBulletScript.currentTier == 0) {
            spriteRenderer.sprite = price500;
        }
        if (shopBulletScript.currentTier >= 1) {
            spriteRenderer.sprite = priceOut;
        }
    }
}
