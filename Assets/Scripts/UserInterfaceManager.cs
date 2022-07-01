using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UserInterfaceManager : MonoBehaviour
{
    public static UserInterfaceManager Instance { get; private set; }
    private bool isMainMenu;

    private bool isOptionMenuOpen;
    private void Awake()
    {
        Instance = this;
    }

    public void MainMenu()
    {
        isMainMenu = true;
    }

    public void OptionMenuPopup()
    {
        isOptionMenuOpen = true;
    }
}