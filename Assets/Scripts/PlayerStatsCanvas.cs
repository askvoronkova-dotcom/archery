using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStatsCanvas : MonoBehaviour
{
    public TextMeshProUGUI playerTowerHealthCount;
    public void UpdateTowerHealthText(int newHealth)
    {
        playerTowerHealthCount.text = newHealth.ToString();
    }
}
