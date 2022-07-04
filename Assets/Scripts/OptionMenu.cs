using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
    public void ShowOptionMenu()
    {
        UserInterfaceManager.Instance.CurrentState = UserInterfaceManager.UIScreenPanel.Active;
        gameObject.SetActive(true);
    }

    private void OnDisable()
    {
        UserInterfaceManager.Instance.CurrentState = UserInterfaceManager.UIScreenPanel.Notactive;
    }
}
