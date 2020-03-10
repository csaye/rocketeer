using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSliders : MonoBehaviour
{

    public GameObject customize;

    public GUIStyle slider;
    public GUIStyle thumb;

    public float xPos, yPos;

    private SpriteRenderer spriteRenderer;

    private Color color;

    private bool activated = false;

    private float red, green, blue;
    private float yPosConstant;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        yPosConstant = yPos;

        red = 1;
        green = 1;
        blue = 1;
    }

    void Update() {
        
        CheckActivated();

        UpdateYPos();
    }

    private void CheckActivated() {
        if (customize.transform.position.y == 72) {
            activated = true;
        } else {
            activated = false;
        }
    }

    private void UpdateYPos() {
        if (activated) {
            yPos = yPosConstant;
        } else {
            yPos = 9999;
        }
    }

    private void OnGUI()
    {

        red = GUI.HorizontalSlider(new Rect(xPos, yPos, 200, 30), red, 0, 1, slider, thumb);

        green = GUI.HorizontalSlider(new Rect(xPos, yPos + 35, 200, 30), green, 0, 1, slider, thumb);

        blue = GUI.HorizontalSlider(new Rect(xPos, yPos + 70, 200, 30), blue, 0, 1, slider, thumb);

        color = new Color(red, green, blue);

        spriteRenderer.color = color;
    }
}
