using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollactableGreenCoin : ItemCollactableBase
{
    public Collider2D myCollider;

    protected override void OnCollect()
    {
        base.OnCollect();

        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.PlaySFX(AudioManager.Instance.coinSound);
        }

        ItemManager.Instance.AddGreenCoins();

        if (myCollider != null) myCollider.enabled = false;
    }
}

