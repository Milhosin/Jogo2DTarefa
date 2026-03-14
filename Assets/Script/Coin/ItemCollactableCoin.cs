using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollactableCoin : ItemCollactableBase
{
    protected override void OnCollect()
    {
        base.OnCollect();

        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.coinSound);
        }

        ItemManager.Instance.AddCoins();
    }
}



