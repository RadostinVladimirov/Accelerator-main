using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameScript : MonoBehaviour
{

    [SerializeField]
    private UserInterfaceManager UI_manager;

    public OptionsMenu options_menu;

    public void NewGame()
    {
        if(options_menu.MenuActive == true)
        {
            options_menu.CloseMenu();
        }
        else if(options_menu. MenuActive == false)
        {
            SceneManager.LoadScene("Game");
            UI_manager.WhereIam(2);
        }       
    }
}
