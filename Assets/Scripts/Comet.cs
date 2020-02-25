using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comet : MonoBehaviour
{

public float cometSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FadeDown();
        CheckDestroy();
    }

    private void FadeDown() {
        transform.position = new Vector2(transform.position.x, transform.position.y - cometSpeed);
    }

    private void CheckDestroy() {
        if (transform.position.y < -15) {
            Destroy(gameObject);
        }
    }

}
