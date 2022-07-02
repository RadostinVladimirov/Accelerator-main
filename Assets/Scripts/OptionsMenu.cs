using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    
    public GameObject options_menu;

    [SerializeField]
    private UserInterfaceManager UI_manager;

    private void Awake()
    {
        options_menu.SetActive(false);
    }

    public void OpenMenu()
    {
        options_menu.SetActive(true);
        UI_manager.WhereIam("OptionsMenu");
    }

    public void CloseMenu()
    {
        options_menu.SetActive(false);
        UI_manager.WhereIam("MainMenu");
    }

   
}
