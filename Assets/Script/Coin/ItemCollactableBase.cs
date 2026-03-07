using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollactableBase : MonoBehaviour
{
    public string compareTag = "Player";
    public new ParticleSystem particleSystem;
    public float timeToHide = 3;
    public GameObject graphicItem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(compareTag))
        {
            Collect();
        }
    }

    private void HideObject()
    {
        gameObject.SetActive(false);
    }

    protected virtual void Collect()
    {
        if (graphicItem != null) graphicItem.SetActive(false);
        Invoke("HideObject", timeToHide);
        OnCollect();
    }

    protected virtual void OnCollect()
    {
        if (particleSystem != null) particleSystem.Play();
    }
}
