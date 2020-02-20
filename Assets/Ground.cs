using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

public float fadeSpeed;

private bool liftOff = false;

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
