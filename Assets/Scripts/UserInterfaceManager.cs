using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UserInterfaceManager : MonoBehaviour
{
    public static UserInterfaceManager Instance { get; private set; }

    [SerializeField]
    private Text playerNameText;

    [SerializeField]
    private InputField inputFieldText;

    private string currentPlayerName;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        currentPlayerName = GetSavedPlayerName();
        playerNameText.text = currentPlayerName;
    }

    public void SetPlayerName()
    {
        playerNameText.text = currentPlayerName;
        playerNameText.text = inputFieldText.text;
        SavePlayerName();
    }


    private void SavePlayerName()
    {
        PlayerPrefs.SetString("PlayerName", playerNameText.text);
    }


    private string GetSavedPlayerName() => PlayerPrefs.GetString("PlayerName");

}