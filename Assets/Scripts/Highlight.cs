using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{

public Sprite normal;
public Sprite light;

private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        if (spriteRenderer.sprite == null) {
            spriteRenderer.sprite = normal;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckHighlight();
    }

    private void CheckHighlight() {
        if (Input.mousePosition.x >= 270.1f && Input.mousePosition.x <= 589 && Input.mousePosition.y >= 194.1f && Input.mousePosition.y <= 265.3f) {
            Light();
        } else {
            Normal();
        }
    }

    private void Light() {
        spriteRenderer.sprite = light;
    }

    private void Normal() {
        spriteRenderer.sprite = normal;
    }
}
