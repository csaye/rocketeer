using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceCoins : MonoBehaviour
{

public GameObject shopCoins;
public GameObject shop;

public Sprite price100;
public Sprite price200;
public Sprite price300;
public Sprite priceOut;

private ShopCoins shopCoinsScript;

private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        shopCoinsScript = shopCoins.GetComponent<ShopCoins>();
    }

    void Update()
    {
        if (shop.transform.position.y == 24) {
            CheckPrice();
        }
    }

    private void CheckPrice() {
        if (shopCoinsScript.currentTier == 1) {
            spriteRenderer.sprite = price100;
        }
        if (shopCoinsScript.currentTier == 2) {
            spriteRenderer.sprite = price200;
        }
        if (shopCoinsScript.currentTier == 3) {
            spriteRenderer.sprite = price300;
        }
        if (shopCoinsScript.currentTier > 3) {
            spriteRenderer.sprite = priceOut;
        }
    }
}
