using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{

public float flashSpeed;

private float frames;

private bool flashOn = true;
private bool liftOff = false;

    // Start is called before the first frame update
    void Start()
    {
        frames = flashSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (!liftOff) {
            FlashText();
            CheckFlash();
            CheckLiftOff();
        }
    }

    private void CheckLiftOff() {
        if (Input.GetKeyDown("space")) {
            liftOff = true;
            transform.position = new Vector2(transform.position.x, -999);
        }
    }

    private void FlashText() {
        if (frames == 0) {
            frames = flashSpeed;
            flashOn = !flashOn;
        }
        frames--;
    }

    private void CheckFlash() {
        if (flashOn) {
            transform.position = new Vector2(transform.position.x, -10.35f);
        }
        if (!flashOn) {
            transform.position = new Vector2(transform.position.x, -999);
        }
    }
}
