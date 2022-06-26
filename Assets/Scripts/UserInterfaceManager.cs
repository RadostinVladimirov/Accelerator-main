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

    [SerializeField]
    private Text Clock;

    [System.Serializable]
    public class ClockInputs
    {
        public int Hour_Clock;
        public int Minute_Clock;

        public ClockInputs()
        {
            Hour_Clock = System.DateTime.Now.Hour;
            Minute_Clock = System.DateTime.Now.Minute;
        }
    }

    [System.Serializable]
    public class PlayerEnterValue
    {
        public int EnterValue;
        public int TimesGameStarted;
        public Text playerEnterValueText;
        public void UpdateEnterValue()
        {
            TimesGameStarted = PlayerPrefs.GetInt("TimesGameStarted");
            TimesGameStarted += 1;
            EnterValue = TimesGameStarted;
            playerEnterValueText.text = "Game Played" + " " + EnterValue + " " + "Times";
            PlayerPrefs.SetInt("TimesGameStarted", EnterValue);
        }
    }


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        currentPlayerName = GetSavedPlayerName();
        playerNameText.text = currentPlayerName;
        EnterTimes.UpdateEnterValue();
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

    public void ResetName()
    {
        inputFieldText.text = " ";
        playerNameText.text = " ";
        PlayerPrefs.SetString("PlayerName", playerNameText.text);
    }

    public void OpenGoogleClock(string link)
    {
        Application.OpenURL(link);
    }


    private string GetSavedPlayerName() => PlayerPrefs.GetString("PlayerName");

    public ClockInputs ClockInputsInstance = new ClockInputs();
    public PlayerEnterValue EnterTimes = new PlayerEnterValue();

    public void FixedUpdate()
    {
        ClockInputsInstance.Hour_Clock = System.DateTime.Now.Hour;
        ClockInputsInstance.Minute_Clock = System.DateTime.Now.Minute;
        Clock.text = "" + ClockInputsInstance.Hour_Clock + ":" + ClockInputsInstance.Minute_Clock;
    }


}



