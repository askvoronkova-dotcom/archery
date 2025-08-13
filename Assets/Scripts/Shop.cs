using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public PlayerDataManager playerDataManager;
    public Button shopButton1;
    public Button shopButton2;
    public Button shopButton3;

    private void Start()
    {
        playerDataManager = FindObjectOfType<PlayerDataManager>();
        playerDataManager.LoadPlayerData();
    }
}
