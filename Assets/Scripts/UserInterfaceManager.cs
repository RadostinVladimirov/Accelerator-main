using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum PageFinder 
{  
    Main_Menu, 
    Options_Menu, 
    New_Game
}

public class UserInterfaceManager : MonoBehaviour
{
    public static UserInterfaceManager Instance { get; private set; }
    public PageFinder Page;

    public OptionsMenu options_menu;


    private void Awake()
    {
        Instance = this;
        Page = PageFinder.Options_Menu;
    }

    public void ExitGame()
    {
        if(options_menu.MenuActive == true)
        {
            options_menu.CloseMenu();
        }
        else if(options_menu.MenuActive == false)
        {
            Application.Quit();
        }
        
    }

    public void WhereIam(int screen)
    {
        Page = (PageFinder)screen;
    }

}



