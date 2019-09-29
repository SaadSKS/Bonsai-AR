using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple short script to Toggle TitleScreen Visibilty

public class ToggleAnimEvent : MonoBehaviour
{
    public GameObject TitleScreenPanel;


    public void ToggleTitleScreen()
    {
        TitleScreenPanel.SetActive(!TitleScreenPanel.activeSelf);
    }
}
