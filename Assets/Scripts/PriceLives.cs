using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceLives : MonoBehaviour
{

public GameObject shopLives;
public GameObject shop;

public Sprite price100;
public Sprite price200;
public Sprite price300;
public Sprite priceOut;

private ShopLives shopLivesScript;

private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        shopLivesScript = shopLives.GetComponent<ShopLives>();
    }

    void Update()
    {
        if (shop.transform.position.y == 24) {
            CheckPrice();
        }
    }

    private void CheckPrice() {
        if (shopLivesScript.currentTier == 1) {
            spriteRenderer.sprite = price100;
        }
        if (shopLivesScript.currentTier == 2) {
            spriteRenderer.sprite = price200;
        }
        if (shopLivesScript.currentTier == 3) {
            spriteRenderer.sprite = price300;
        }
        if (shopLivesScript.currentTier > 3) {
            spriteRenderer.sprite = priceOut;
        }
    }
}
