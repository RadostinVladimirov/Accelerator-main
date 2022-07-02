using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameScript : MonoBehaviour
{

    [SerializeField]
    private UserInterfaceManager UI_manager;

    public void NewGame()
    {
        SceneManager.LoadScene("Game");
        UI_manager.WhereIam("NewGame");
    }
}
