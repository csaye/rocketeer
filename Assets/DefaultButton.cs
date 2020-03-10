using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultButton : MonoBehaviour
{

public GameObject shop;
public GameObject achievements;
public GameObject customize;
public GameObject buttonController;
public GameObject rocketDefault;

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
            rocketDefault.GetComponent<Renderer>().enabled = false;
        }
    }

    private void CheckHighlight() {
        if (Input.mousePosition.x >= 16.1f && Input.mousePosition.x <= 176.4f &&
        Input.mousePosition.y >= 340.6f && Input.mousePosition.y <= 382) {
            Light();
            if (Input.GetMouseButtonDown(0)) {
                buttonControllerScript.defaultMode = false;
            }
        } else {
            Normal();
        }
    }

    private void CheckShow() {
        if (buttonControllerScript.defaultMode) {
            GetComponent<Renderer>().enabled = true;
            rocketDefault.GetComponent<Renderer>().enabled = true;
        } else {
            GetComponent<Renderer>().enabled = false;
            rocketDefault.GetComponent<Renderer>().enabled = false;
        }
    }

    private void Light() {
        spriteRenderer.sprite = light;
    }

    private void Normal() {
        spriteRenderer.sprite = normal;
    }
}
