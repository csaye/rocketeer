using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSliders : MonoBehaviour
{

    public GameObject customize;

    public float xPos, yPos;

    private SpriteRenderer m_SpriteRenderer;

    private Color m_NewColor;

    private bool activated = false;

    private float m_Red, m_Blue, m_Green;
    private float yPosConstant;

    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.blue;

        yPosConstant = yPos;
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

        m_Red = GUI.HorizontalSlider(new Rect(xPos, yPos, 200, 30), m_Red, 0, 1);

        m_Green = GUI.HorizontalSlider(new Rect(xPos, yPos + 35, 200, 30), m_Green, 0, 1);

        m_Blue = GUI.HorizontalSlider(new Rect(xPos, yPos + 70, 200, 30), m_Blue, 0, 1);

        m_NewColor = new Color(m_Red, m_Green, m_Blue);

        m_SpriteRenderer.color = m_NewColor;
    }
}
