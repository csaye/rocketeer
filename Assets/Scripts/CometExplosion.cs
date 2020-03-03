using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometExplosion : MonoBehaviour
{

public GameObject comet;
public GameObject shop;

private float frames = 30;

private bool exploded;

    void Start()
    {
        GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        MoveToComet();
        CheckShow();
        
        if (GetComponent<Renderer>().enabled == true) {
            CheckDelay();
        }
    }

    private void CheckShow() {
        if (shop.transform.position.y != 24) {
            if (!comet.GetComponent<Renderer>().enabled) {
                if (!exploded) {
                    GetComponent<Renderer>().enabled = true;
                    exploded = true;
                }
            } else {
                frames = 30;
                GetComponent<Renderer>().enabled = false;
            }
        } else {
            GetComponent<Renderer>().enabled = false;
        }
    }

    private void MoveToComet() {
        transform.position = new Vector2(comet.transform.position.x, comet.transform.position.y);
        if (comet.transform.position.y == 15) {
            exploded = false;
        }
    }

    private void CheckDelay() {
        if (frames == 0) {
            GetComponent<Renderer>().enabled = false;
            frames = 30;
        }
        frames--;
    }
}
