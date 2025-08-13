using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    private EndGameCanvas endGameCanvas;

    public PlayerStatsCanvas playerStatsCanvas;
    void Start()
    {
        currentHealth = maxHealth;
        playerStatsCanvas = FindObjectOfType<PlayerStatsCanvas>();
        playerStatsCanvas.UpdateTowerHealthText(currentHealth);
        endGameCanvas = FindObjectOfType<EndGameCanvas>();

    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        playerStatsCanvas.UpdateTowerHealthText(currentHealth);
        if (currentHealth <= 0)
        {
            GameOver();
        }
    }
    void GameOver()
    {
        Debug.Log("GameOver!");
        endGameCanvas.TurnOnLoseScreen();
    }
}
