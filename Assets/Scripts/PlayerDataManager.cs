using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDataManager : MonoBehaviour
{
    public int playerLevel;
    public int playerDamage;
    public int playerHp;
    public int playerArmor;
    public int playerCoins;
    public int playerSkin1;
    public int playerSkin2;
    public int playerSkin3;


    public void SavePlayerLevel()
    {
        PlayerPrefs.SetInt("PlayerLevel", playerLevel);
        PlayerPrefs.Save();
    }
    public void SavePlayerDamage()
    {
        PlayerPrefs.SetInt("PlayerDamage", playerDamage);
        PlayerPrefs.Save();
    }
    public void SavePlayerHp()
    {
        PlayerPrefs.SetInt("PlayerHp", playerHp);
        PlayerPrefs.Save();
    }
    public void SavePlayerArmor()
    {
        PlayerPrefs.SetInt("PlayerArmor", playerArmor);
        PlayerPrefs.Save();
    }
    public void SavePlayerCoins()
    {
        PlayerPrefs.SetInt("PlayerCoins", playerCoins);
        PlayerPrefs.Save();
    }
    public void SavePlayerSkin1()
    {
        PlayerPrefs.SetInt("PlayerSkin1", playerSkin1);
        PlayerPrefs.Save();
    }
    public void SavePlayerSkin2()
    {
        PlayerPrefs.SetInt("PlayerSkin2", playerSkin2);
        PlayerPrefs.Save();
    }
    public void SavePlayerSkin3()
    {
        PlayerPrefs.SetInt("PlayerSkin3", playerSkin3);
        PlayerPrefs.Save();
    }
  
    public void LoadPlayerData()
    {
        if (PlayerPrefs.HasKey("PlayerLevel"))
            playerLevel = PlayerPrefs.GetInt("PlayerLevel");

        if (PlayerPrefs.HasKey("PlayerDamage"))
            playerDamage = PlayerPrefs.GetInt("PlayerDamage");

        if (PlayerPrefs.HasKey("PlayerHp"))
            playerHp = PlayerPrefs.GetInt("PlayerHp");

        if (PlayerPrefs.HasKey("PlayerArmor"))
            playerArmor = PlayerPrefs.GetInt("PlayerArmor");

        if (PlayerPrefs.HasKey("PlayerCoins"))
            playerCoins = PlayerPrefs.GetInt("PlayerCoins");

        if (PlayerPrefs.HasKey("PlayerSkin1"))
            playerSkin1 = PlayerPrefs.GetInt("PlayerSkin1");

        if (PlayerPrefs.HasKey("PlayerSkin2"))
            playerSkin2 = PlayerPrefs.GetInt("PlayerSkin2");

        if (PlayerPrefs.HasKey("PlayerSkin3"))
            playerSkin3 = PlayerPrefs.GetInt("PlayerSkin3");

        if (PlayerPrefs.HasKey("PlayerSkin4"))
            playerSkin4 = PlayerPrefs.GetInt("PlayerSkin14");
    }

    public void ClearPlayerData()
    {
        PlayerPrefs.DeleteAll();
    }
}
