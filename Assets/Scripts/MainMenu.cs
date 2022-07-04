using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        UserInterfaceManager.Instance.CurrentState = UserInterfaceManager.UIScreenPanel.Active;
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void OnDisable()
    {
        UserInterfaceManager.Instance.CurrentState = UserInterfaceManager.UIScreenPanel.Notactive;
    }
}
