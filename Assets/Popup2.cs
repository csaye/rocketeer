using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup2 : MonoBehaviour
{

public GameObject achievement2;

private Achievement achievementScript;

    void Start()
    {
        achievementScript = achievement2.GetComponent<Achievement>();
    }

    void Update()
    {
        
    }
}
