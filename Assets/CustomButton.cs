using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomButton : MonoBehaviour
{

public GameObject shop;
public GameObject achievements;
public GameObject customize;
public GameObject buttonController;

public Sprite normal;
public Sprite light;

private ButtonController buttonControllerScript;

private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        buttonControllerScript = buttonController.GetComponent<ButtonController>();
    }

    void Update()
    {
        if (customize.transform.position.y == 72 && GetComponent<Renderer>().enabled) {
            CheckHighlight();
        }

        if (customize.transform.position.y == 72) {
            CheckShow();
        } else {
            GetComponent<Renderer>().enabled = false;
        }
    }

    private void CheckHighlight() {
        if (Input.mousePosition.x >= 26.4f && Input.mousePosition.x <= 172.6f &&
        Input.mousePosition.y >= 339.7f && Input.mousePosition.y <= 384.8f) {
            Light();
            if (Input.GetMouseButtonDown(0)) {
                buttonControllerScript.defaultMode = true;
            }
        } else {
            Normal();
        }
    }

    private void CheckShow() {
        if (!buttonControllerScript.defaultMode) {
            GetComponent<Renderer>().enabled = true;
        } else {
            GetComponent<Renderer>().enabled = false;
        }
    }

    private void Light() {
        spriteRenderer.sprite = light;
    }

    private void Normal() {
        spriteRenderer.sprite = normal;
    }
}
