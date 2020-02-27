using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{

public GameObject shop;
public GameObject achievements;

public Sprite normal;
public Sprite light;

private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (achievements.transform.position.y == 48) {
            CheckHighlight();
        }
    }

    private void CheckHighlight() {
        if (Input.mousePosition.x >= 746.9f && Input.mousePosition.x <= 847.7f &&
        Input.mousePosition.y >= 356.6f && Input.mousePosition.y <= 400.6f) {
            Light();
            if (Input.GetMouseButtonDown(0)) {
                ShopMenu();
            }
        } else {
            Normal();
        }
    }

    private void ShopMenu() {
        achievements.transform.position = new Vector2(0, 0);
    }

    private void Light() {
        spriteRenderer.sprite = light;
    }

    private void Normal() {
        spriteRenderer.sprite = normal;
    }
}
