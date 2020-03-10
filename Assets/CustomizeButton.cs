using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeButton : MonoBehaviour
{

public GameObject shop;
public GameObject achievements;
public GameObject customize;

public Sprite normal;
public Sprite light;

private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (shop.transform.position.y == 24 && achievements.transform.position.y != 48 && customize.transform.position.y != 72) {
            CheckHighlight();
        }
    }

    private void CheckHighlight() {
        if (Input.mousePosition.x >= 225.1f && Input.mousePosition.x <= 274.3 &&
        Input.mousePosition.y >= 328.2f && Input.mousePosition.y <= 377.8f) {
            Light();
            if (Input.GetMouseButtonDown(0)) {
                CustomizeMenu();
            }
        } else {
            Normal();
        }
    }

    private void CustomizeMenu() {
        customize.transform.position = new Vector2(0, 72);
    }

    private void Light() {
        spriteRenderer.sprite = light;
    }

    private void Normal() {
        spriteRenderer.sprite = normal;
    }
}
