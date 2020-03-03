using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{

public GameObject cometController;
public GameObject heart1;
public GameObject heart2;
public GameObject heart3;
public GameObject shop;

public Sprite heartGold;
public Sprite heart;
public Sprite heartDead;

private CometController cometControllerScript;

private SpriteRenderer spriteRenderer1;
private SpriteRenderer spriteRenderer2;
private SpriteRenderer spriteRenderer3;

    void Start()
    {
        cometControllerScript = cometController.GetComponent<CometController>();

        spriteRenderer1 = heart1.GetComponent<SpriteRenderer>();
        spriteRenderer2 = heart2.GetComponent<SpriteRenderer>();
        spriteRenderer3 = heart3.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        UpdateLives();
        CheckShow();
    }

    private void UpdateLives() {
        if (cometControllerScript.lives == 0) {
            spriteRenderer1.sprite = heartDead;
            spriteRenderer2.sprite = heartDead;
            spriteRenderer3.sprite = heartDead;
        }
        if (cometControllerScript.lives == 1) {
            spriteRenderer1.sprite = heart;
            spriteRenderer2.sprite = heartDead;
            spriteRenderer3.sprite = heartDead;
        }
        if (cometControllerScript.lives == 2) {
            spriteRenderer1.sprite = heart;
            spriteRenderer2.sprite = heart;
            spriteRenderer3.sprite = heartDead;
        }
        if (cometControllerScript.lives == 3) {
            spriteRenderer1.sprite = heart;
            spriteRenderer2.sprite = heart;
            spriteRenderer3.sprite = heart;
        }
        if (cometControllerScript.lives == 4) {
            spriteRenderer1.sprite = heartGold;
            spriteRenderer2.sprite = heart;
            spriteRenderer3.sprite = heart;
        }
        if (cometControllerScript.lives == 5) {
            spriteRenderer1.sprite = heartGold;
            spriteRenderer2.sprite = heartGold;
            spriteRenderer3.sprite = heart;
        }
        if (cometControllerScript.lives >= 6) {
            spriteRenderer1.sprite = heartGold;
            spriteRenderer2.sprite = heartGold;
            spriteRenderer3.sprite = heartGold;
        }
    }

    private void CheckShow() {
        if (shop.transform.position.y == 24) {
            heart1.GetComponent<Renderer>().enabled = false;
            heart2.GetComponent<Renderer>().enabled = false;
            heart3.GetComponent<Renderer>().enabled = false;
        } else {
            heart1.GetComponent<Renderer>().enabled = true;
            heart2.GetComponent<Renderer>().enabled = true;
            heart3.GetComponent<Renderer>().enabled = true;
        }
    }
}
