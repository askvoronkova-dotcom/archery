using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private PlayerDataManager data;

    public event Action<int> OnCoinsChanged;
    void Start()
    {
        if (data == null) data = FindObjectOfType<PlayerDataManager>();
        OnCoinsChanged?.Invoke(data.playerCoins);
    }

    public void AddCoins(int amount)
    {
        if (amount <= 0) return;
        data.playerCoins += amount;
        data.SavePlayerCoins();
        OnCoinsChanged?.Invoke(data.playerCoins);
    }

    public bool TrySpendCoins(int amount)
    {
        if (amount < 0) amount = 0;
        if (data.playerCoins >= amount)
        {
            data.playerCoins -= amount;
            data.SavePlayerCoins();
            OnCoinsChanged?.Invoke(data.playerCoins);
            return true;
        }
        return false;
    }
    public int GetCoins() => data.playerCoins;
}
