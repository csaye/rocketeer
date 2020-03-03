using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceMaxScore : MonoBehaviour
{

public GameObject shopMaxScore;
public GameObject shop;

public Sprite price1000;
public Sprite priceOut;

private ShopMaxScore shopMaxScoreScript;

private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        shopMaxScoreScript = shopMaxScore.GetComponent<ShopMaxScore>();
    }

    void Update()
    {
        if (shop.transform.position.y == 24 && shopMaxScore.GetComponent<Renderer>().enabled == true) {
            CheckPrice();
            GetComponent<Renderer>().enabled = true;
        } else {
            GetComponent<Renderer>().enabled = false;
        }
    }

    private void CheckPrice() {
        if (shopMaxScoreScript.currentTier == 1) {
            spriteRenderer.sprite = price1000;
        }
        if (shopMaxScoreScript.currentTier > 1) {
            spriteRenderer.sprite = priceOut;
        }
    }
}
