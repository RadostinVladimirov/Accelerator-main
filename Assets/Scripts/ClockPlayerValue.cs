using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClockPlayerValue : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI playerEnterValueDisplay;
    [SerializeField]
    private TextMeshProUGUI clockText;

    private int hour;
    private int minute;

    [SerializeField]
    private int playerEnterValue;
    private void Start()
    {
        playerEnterValue = GetPlayerValue();
        PlayerCount();
    }

    private void PlayerCount()
    {
        playerEnterValue++;
        PlayerPrefs.SetInt("Player", playerEnterValue);
        PlayerPrefs.Save();
        playerEnterValueDisplay.text = "Player Enter Value: " + playerEnterValue;
    }

    private void Update()
    {
        StartCoroutine(ClockOnMyDevice());
    }

    private IEnumerator ClockOnMyDevice()
    {
        hour = System.DateTime.Now.Hour;
        minute = System.DateTime.Now.Minute;
        clockText.text = "Clock: " + hour + " : " + minute;
        yield return new WaitForSeconds(1f);
    }

    public void ResetPlayerCount()
    {
        PlayerPrefs.DeleteKey("Player");
        playerEnterValue = GetPlayerValue();
        playerEnterValueDisplay.text = "Player Enter Value: " + playerEnterValue.ToString();
    }

    private int GetPlayerValue()
    {
        return PlayerPrefs.GetInt("Player"); 
    }
}
