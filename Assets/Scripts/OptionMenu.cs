using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
   public void ShowOptionMenu()
    {
        UserInterfaceManager.Instance.OptionMenuPopup();
        gameObject.SetActive(true);
    }
}
