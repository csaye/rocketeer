using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomRocket : MonoBehaviour
{

public GameObject buttonController;
public GameObject rocketPart;

private ButtonController buttonControllerScript;

private SpriteRenderer spriteRenderer;
private SpriteRenderer rocketPartSpriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rocketPartSpriteRenderer = rocketPart.GetComponent<SpriteRenderer>();

        buttonControllerScript = buttonController.GetComponent<ButtonController>();
    }

    void Update()
    {
        CheckShow();
        ChangeColor();
    }

    private void CheckShow() {
        if (buttonControllerScript.defaultMode) {
            GetComponent<Renderer>().enabled = false;
        } else {
            GetComponent<Renderer>().enabled = true;
        }
    }

    private void ChangeColor() {
        spriteRenderer.color = rocketPartSpriteRenderer.color;
    }
}
