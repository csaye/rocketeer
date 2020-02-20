using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInfo : MonoBehaviour
{

private bool liftOff = false;

public float fadeSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!liftOff) {
            CheckLiftOff();
        }

        if (liftOff && transform.position.y > -15) {
            FadeDown();
        }
    }

    private void CheckLiftOff() {
        if (Input.GetKeyDown("space")) {
            liftOff = true;
        }
    }

    private void FadeDown() {
        transform.position = new Vector2(transform.position.x, transform.position.y - fadeSpeed);
    }
}
