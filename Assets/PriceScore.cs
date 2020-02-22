using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceScore : MonoBehaviour
{

public GameObject shopScore;
public GameObject shop;

public Sprite price100;
public Sprite price200;
public Sprite price300;
public Sprite priceOut;

private ShopScore shopScoreScript;

private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        shopScoreScript = shopScore.GetComponent<ShopScore>();
    }

    void Update()
    {
        if (shop.transform.position.y == 24) {
            CheckPrice();
        }
    }

    private void CheckPrice() {
        if (shopScoreScript.currentTier == 1) {
            spriteRenderer.sprite = price100;
        }
        if (shopScoreScript.currentTier == 2) {
            spriteRenderer.sprite = price200;
        }
        if (shopScoreScript.currentTier == 3) {
            spriteRenderer.sprite = price300;
        }
        if (shopScoreScript.currentTier > 3) {
            spriteRenderer.sprite = priceOut;
        }
    }
}
