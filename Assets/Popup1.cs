using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup1 : MonoBehaviour
{

public GameObject achievement1;

private Achievement achievementScript;

    void Start()
    {
        achievementScript = achievement1.GetComponent<Achievement>();
    }

    void Update()
    {
        
    }
}
