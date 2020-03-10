using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceMaxCoins : MonoBehaviour
{

public GameObject shopMaxCoins;
public GameObject shop;

public Sprite price1000;
public Sprite priceOut;

private ShopMaxCoins shopMaxCoinsScript;

private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        shopMaxCoinsScript = shopMaxCoins.GetComponent<ShopMaxCoins>();
    }

    void Update()
    {
        if (shop.transform.position.y == 24 && shopMaxCoins.GetComponent<Renderer>().enabled == true) {
            CheckPrice();
            GetComponent<Renderer>().enabled = true;
        } else {
            GetComponent<Renderer>().enabled = false;
        }
    }

    private void CheckPrice() {
        if (shopMaxCoinsScript.currentTier == 1) {
            spriteRenderer.sprite = price1000;
        }
        if (shopMaxCoinsScript.currentTier > 1) {
            spriteRenderer.sprite = priceOut;
        }
    }
}
