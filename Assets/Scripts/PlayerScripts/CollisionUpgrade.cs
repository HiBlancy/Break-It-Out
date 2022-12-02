using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionUpgrade : MonoBehaviour
{
    AudioSource audioUpgarde;
    private void Start()
    {
        audioUpgarde = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Upgrade"))
        {
            audioUpgarde.Play();
            SelectUpgrade.Obj.CallingUpgrade();
        }
    }
}