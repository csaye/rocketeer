using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

public GameObject menuGrayAchievements;
public GameObject menuGrayShop;
public GameObject shop;
public GameObject achievements;

public Text achievementsText;
public Text shopText;

    void Start()
    {
        
    }


    void Update()
    {
        UpdateButtonStatus();
    }

    private void UpdateButtonStatus() {
        if (achievements.transform.position.y == 48) {

            menuGrayAchievements.GetComponent<Renderer>().enabled = false;
            menuGrayShop.GetComponent<Renderer>().enabled = true;

            achievementsText.enabled = false;
            shopText.enabled = true;

        } else if (shop.transform.position.y == 24) {

            menuGrayAchievements.GetComponent<Renderer>().enabled = true;
            menuGrayShop.GetComponent<Renderer>().enabled = false;

            achievementsText.enabled = true;
            shopText.enabled = false;
        
        } else {

            menuGrayAchievements.GetComponent<Renderer>().enabled = false;
            menuGrayShop.GetComponent<Renderer>().enabled = false;

            achievementsText.enabled = false;
            shopText.enabled = false;

        }
    }
}
