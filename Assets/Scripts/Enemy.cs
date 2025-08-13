using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    private PlayerHealth player;

    private EndGameCanvas canvas;

    private void Start()
    {
        canvas = FindObjectOfType<EndGameCanvas>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
        canvas.TurnOnWinScreen();
    }
}
