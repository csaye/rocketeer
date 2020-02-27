using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometExplosion : MonoBehaviour
{

public GameObject comet;
public GameObject shop;

    void Start()
    {

    }

    void Update()
    {
        MoveToComet();
        CheckShow();
    }

    private void CheckShow() {
        if (shop.transform.position.y != 24) {
            if (!comet.GetComponent<Renderer>().enabled) {
                GetComponent<Renderer>().enabled = true;    
            } else {
                GetComponent<Renderer>().enabled = false;
            }
        } else {
            GetComponent<Renderer>().enabled = false;
        }
    }

    private void MoveToComet() {
        transform.position = new Vector2(comet.transform.position.x, comet.transform.position.y);
    }
}
