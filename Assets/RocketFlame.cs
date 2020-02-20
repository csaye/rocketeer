using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFlame : MonoBehaviour
{

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
    }

    private void CheckLiftOff() {
        if (Input.GetKeyDown("space")) {
            liftOff = true;
            transform.localPosition = new Vector2(transform.position.x, -10.56f);
        }
    }
}
