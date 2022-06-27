using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{

    private int EnterValue;
    private int TimesGameStarted;
    [SerializeField]
    public Text playerEnterValueText;

   
    private int Hour_Clock;
    private int Minute_Clock;
    [SerializeField]
    private Text clock;


    void Start()
    {
        UpdateEnterValue();
    }

    void Update()
    {
        
    }

    public void FixedUpdate()
    {
        Hour_Clock = System.DateTime.Now.Hour;
        Minute_Clock = System.DateTime.Now.Minute;
        clock.text = "" + Hour_Clock + ":" + Minute_Clock;
    }

    public void UpdateEnterValue()
    {
        TimesGameStarted = PlayerPrefs.GetInt("TimesGameStarted");
        TimesGameStarted += 1;
        EnterValue = TimesGameStarted;
        playerEnterValueText.text = "Game Played" + " " + EnterValue + " " + "Times";
        PlayerPrefs.SetInt("TimesGameStarted", EnterValue);
    }
}
