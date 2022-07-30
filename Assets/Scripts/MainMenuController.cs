using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{

    [SerializeField]
    private GameObject main_menu;
    
    [SerializeField]
    private UserInterfaceManager UI_manager;


    public void Awake()
    {
        main_menu.SetActive(false);
        StartCoroutine(MenuIntro());
    }

    IEnumerator MenuIntro()
    {
        yield return new WaitForSeconds(3.5f);
        main_menu.SetActive(true);
        UI_manager.WhereIam(0);
    }
}
