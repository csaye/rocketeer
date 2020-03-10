using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceMaxLives : MonoBehaviour
{

public GameObject shopMaxLives;
public GameObject shop;

public Sprite price1000;
public Sprite priceOut;

private ShopMaxLives shopMaxLivesScript;

private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        shopMaxLivesScript = shopMaxLives.GetComponent<ShopMaxLives>();
    }

    void Update()
    {
        if (shop.transform.position.y == 24 && shopMaxLives.GetComponent<Renderer>().enabled == true) {
            CheckPrice();
            GetComponent<Renderer>().enabled = true;
        } else {
            GetComponent<Renderer>().enabled = false;
        }
    }

    private void CheckPrice() {
        if (shopMaxLivesScript.currentTier == 1) {
            spriteRenderer.sprite = price1000;
        }
        if (shopMaxLivesScript.currentTier > 1) {
            spriteRenderer.sprite = priceOut;
        }
    }
}
