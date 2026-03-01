using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollactableCoin : ItemCollactableBase
{
    public bool isGreenCoin = false;

    protected override void OnCollect()
    {
        base.OnCollect();

        if (isGreenCoin)
        {
            ItemManager.Instance.AddGreenCoins();
        }
        else
        {
            ItemManager.Instance.AddCoins();
        }
    }
}
