using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UserInterfaceManager : MonoBehaviour
{
    public static UserInterfaceManager Instance { get; private set; }
    public enum UIScreenPanel
    {
        Active,
        Notactive
    }
    public UIScreenPanel CurrentState;

    private void Awake()
    {
        Instance = this;
    }
}