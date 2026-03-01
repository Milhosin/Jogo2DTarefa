using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ebac.Core.Singleton;

public class ItemManager : Singleton<ItemManager>
{
    public SOInt coins;
    public SOInt coinsGreen;
    public TextMeshProUGUI uiCoins;
    public TextMeshProUGUI uiCoinsGreen;


    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        coins.value = 0;
        coinsGreen.value = 0;
        UpdateUI();
    }

    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
        UpdateUI();
    }

    public void AddGreenCoins(int amount = 1)
    {
        coinsGreen.value += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        uiCoins.text = coins.value.ToString();
        uiCoinsGreen.text = coinsGreen.value.ToString();
    }

}
