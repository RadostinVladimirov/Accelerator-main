using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UserInterfaceManager : MonoBehaviour
{
    public static UserInterfaceManager Instance { get; private set; }


    private void Awake()
    {
        Instance = this;
    }

    public void ExitGame()
    {
        Application.Quit();
        WhereIam("ExitGame");
    }

    public void WhereIam(string page)
    {
        if(page == "MainMenu")
        {
            Debug.Log("Main Menu Entered");
        }
        else if(page == "OptionsMenu")
        {
            Debug.Log("Options Menu Opened");
        }
        else if(page == "LoadGame")
        {
            Debug.Log("Loading Saved Game");
        }
        else if (page == "NewGame")
        {
            Debug.Log("Loading New Game");
        }
        else if (page == "ExitGame")
        {
            Debug.Log("Exit Game");
        }
    }

}



