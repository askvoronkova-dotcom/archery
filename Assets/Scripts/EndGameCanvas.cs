using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGameCanvas : MonoBehaviour
{
    public GameObject WinScreen;
    public GameObject LoseScreen;
    public TextMeshProUGUI HealthText;
    public GameObject player;
    public GameObject enemy;

    private void TurnOffEnvironment()
    {
        player.SetActive(false);
        enemy.SetActive(false);
    }

    public void TurnOnWinScreen()
    { 
        WinScreen.SetActive(true);
        HealthText.gameObject.SetActive(false);
        TurnOffEnvironment();
    }

    public void TurnOnLoseScreen()
    {
        LoseScreen.SetActive(true);
        HealthText.gameObject.SetActive(false);
        TurnOffEnvironment();
    }
}
