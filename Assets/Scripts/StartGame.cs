using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void SwitchScript() {
        SceneManager.LoadScene(sceneName:"Main");
    }
}
