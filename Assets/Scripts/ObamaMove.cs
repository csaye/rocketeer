using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObamaMove : MonoBehaviour
{

public GameObject obamaBlock;

public float bounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMove();
        CheckClip();
    }

    private void CheckMove() {

        if (Input.GetKeyDown("w") || Input.GetKeyDown("up") && transform.position.y < bounds) {
            transform.position = new Vector2(transform.position.x, transform.position.y + 1);
            if (obamaBlock.transform.position == transform.position) {
                obamaBlock.transform.position = new Vector2(transform.position.x, transform.position.y + 1);
            }
        }

        if (Input.GetKeyDown("a") || Input.GetKeyDown("left") && transform.position.x > (bounds * -1)) {
            transform.position = new Vector2(transform.position.x - 1, transform.position.y);
            if (obamaBlock.transform.position == transform.position) {
                obamaBlock.transform.position = new Vector2(transform.position.x - 1, transform.position.y);
            }
        }

        if (Input.GetKeyDown("s") || Input.GetKeyDown("down") && transform.position.y > (bounds * -1)) {
            transform.position = new Vector2(transform.position.x, transform.position.y - 1);
            if (obamaBlock.transform.position == transform.position) {
                obamaBlock.transform.position = new Vector2(transform.position.x, transform.position.y - 1);
            }
        }

        if (Input.GetKeyDown("d") || Input.GetKeyDown("right") && transform.position.x < bounds) {
            transform.position = new Vector2(transform.position.x + 1, transform.position.y);
            if (obamaBlock.transform.position == transform.position) {
                obamaBlock.transform.position = new Vector2(transform.position.x + 1, transform.position.y);
            }
        }

    }

    private void CheckClip() {

        // Out of bounds up
        if (transform.position.y > bounds) {
            transform.position = new Vector2(transform.position.x, bounds);
        }

        // Out of bounds left
        if (transform.position.x < (bounds * -1)) {
            transform.position = new Vector2((bounds * -1), transform.position.y);
        }

        // Out of bounds down
        if (transform.position.y < (bounds * -1)) {
            transform.position = new Vector2(transform.position.x, (bounds * -1));
        }

        // Out of bounds right
        if (transform.position.x > bounds) {
            transform.position = new Vector2(bounds, transform.position.y);
        }
    }
}
