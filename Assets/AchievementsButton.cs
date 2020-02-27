using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementsButton : MonoBehaviour
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
        if (shop.transform.position.y == 24 && GetComponent<Renderer>().enabled == true) {
            CheckHighlight();
        }
    }

    private void CheckHighlight() {
        if (Input.mousePosition.x >= 577.6f && Input.mousePosition.x <= 852 &&
        Input.mousePosition.y >= 356.6f && Input.mousePosition.y <= 400.6f) {
            Light();
            if (Input.GetMouseButtonDown(0)) {
                AchievementsMenu();
            }
        } else {
            Normal();
        }
    }

    private void AchievementsMenu() {
        achievements.transform.position = new Vector2(0, 48);
    }

    private void Light() {
        spriteRenderer.sprite = light;
    }

    private void Normal() {
        spriteRenderer.sprite = normal;
    }
}
