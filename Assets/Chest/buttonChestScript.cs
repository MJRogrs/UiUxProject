using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class buttonChestScript : MonoBehaviour
{
    public GameObject chestButton;
    public GameObject chestPanelCanvas;
    public GameObject exitButton;
    void Start()
    {
        chestPanelCanvas.SetActive(false);
    }

    public void OnMouseEnter()
    {
        chestPanelCanvas.SetActive(true);
        if (exitButton)
        {
            exitButton.SetActive(false);
        }
    }
    
}
