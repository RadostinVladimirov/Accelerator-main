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

    [SerializeField]
    private string currentPlayerName;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        currentPlayerName = GetSavedPlayerName();
        SetPlayerName();
    }

    public void SetPlayerName()
    {
        playerNameText.text = currentPlayerName;
        currentPlayerName = inputField.text;
    }

    public void SavePlayerName()
    {
        currentPlayerName = inputField.text;
        playerNameText.text = currentPlayerName;
        PlayerPrefs.SetString("Name", currentPlayerName);
    }

    public string GetSavedPlayerName()
    {
        return PlayerPrefs.GetString("Name");
    }

    public void DeletSavedName()
    {
        PlayerPrefs.DeleteKey("Name");
        currentPlayerName = GetSavedPlayerName();
        inputField.text = currentPlayerName;
        playerNameText.text = currentPlayerName;
    }
}