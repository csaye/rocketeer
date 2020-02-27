using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement : MonoBehaviour
{

public GameObject achievements;

public Sprite normal;
public Sprite light;
public Sprite unlockedNormal;
public Sprite unlockedLight;

public string description;

public Text achievementDescription;
public Text elev1;
public Text elev2;
public Text best1;
public Text best2;

public float leftX;
public float rightX;
public float downY;
public float upY;

public bool unlocked = false;

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

        CheckTextShow();
    }

    private void CheckHighlight() {
        if (Input.mousePosition.x >= leftX && Input.mousePosition.x <= rightX &&
        Input.mousePosition.y >= downY && Input.mousePosition.y <= upY) {
            Light();
        } else {
            Normal();
        }
    }

    private void Light() {
        if (unlocked) {
            spriteRenderer.sprite = unlockedLight;
        } else {
            spriteRenderer.sprite = light;
        }
        achievementDescription.text = description;
    }

    private void Normal() {
        if (unlocked) {
            spriteRenderer.sprite = unlockedNormal;
        } else {
            spriteRenderer.sprite = normal;
        }

        if (!(Input.mousePosition.x >= 137.6f && Input.mousePosition.x <= 184 && Input.mousePosition.y >= 40.7f && Input.mousePosition.y <= 85.3f)
        && !(Input.mousePosition.x >= 317 && Input.mousePosition.x <= 363.4f && Input.mousePosition.y >= 40.7f && Input.mousePosition.y <= 85.3f)
        && !(Input.mousePosition.x >= 497.6f && Input.mousePosition.x <= 544 && Input.mousePosition.y >= 40.7f && Input.mousePosition.y <= 85.3f)
        && !(Input.mousePosition.x >= 677.6f && Input.mousePosition.x <= 724 && Input.mousePosition.y >= 40.7f && Input.mousePosition.y <= 85.3f)
        && !(Input.mousePosition.x >= 137.6f && Input.mousePosition.x <= 184 && Input.mousePosition.y >= 184.2f && Input.mousePosition.y <= 228.8f)
        && !(Input.mousePosition.x >= 317 && Input.mousePosition.x <= 363.4f && Input.mousePosition.y >= 184.2f && Input.mousePosition.y <= 228.8f)
        && !(Input.mousePosition.x >= 497.6f && Input.mousePosition.x <= 544 && Input.mousePosition.y >= 184.2f && Input.mousePosition.y <= 228.8f)
        && !(Input.mousePosition.x >= 677.6f && Input.mousePosition.x <= 724 && Input.mousePosition.y >= 184.2f && Input.mousePosition.y <= 228.8f)
        ) {
            achievementDescription.text = "";
        }
    }

    private void CheckTextShow() {
        if (achievements.transform.position.y == 48) {
            elev1.enabled = false;
            elev2.enabled = false;
            best1.enabled = false;
            best2.enabled = false;
        } else {
            elev1.enabled = true;
            elev2.enabled = true;
            best1.enabled = true;
            best2.enabled = true;
        }
    }
}

// 137.6x // 184.0x // 317.0x // 363.4x // 497.6x // 544.0x // 677.6x // 724.0x //
// 40.7y // 85.3y // 184.2y // 228.8y //
