using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

public GameObject rocket;
public GameObject shop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckGameOver();
    }

    private void CheckGameOver() {
        if (rocket.transform.position.y == -999 && shop.transform.position.y == 0) {
            transform.position = new Vector2(transform.position.x, 0);
        } else {
            transform.position = new Vector2(transform.position.x, -999);
        }
    }
}
