using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UserInterfaceManager : MonoBehaviour
{
    public static UserInterfaceManager Instance { get; private set; }

    [SerializeField]
    private TextMeshProUGUI playerNameText;
    [SerializeField]
    private TMP_InputField inputField;

    private string currentPlayerName;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        //The chosen name should be loaded and displayed on restart.
        currentPlayerName = GetSavedPlayerName();
        SetPlayerName();
    }

    public void SetPlayerName()
    {
        //this is delaying the name to displayed after i press a button first  until second press the name is shown
        playerNameText.text = currentPlayerName;
        currentPlayerName = inputField.text;
        Debug.Log("SetPlayer():");
    }

    public void SavePlayerName()
    {
        //The chosen name should be saved with PlayerPrefs.
        PlayerPrefs.SetString("Name", playerNameText.text);
        PlayerPrefs.Save();
        Debug.Log("SavePlayerName():");
    }

    private string GetSavedPlayerName()
    {
        //get stored data
        return PlayerPrefs.GetString("Name");
    }
}