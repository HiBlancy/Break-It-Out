using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeFall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Touched Player");

            SelectUpgrade.Obj.CallingUpgrade();

            gameObject.SetActive(false);
        }
        else
            gameObject.SetActive(false);
    }
}