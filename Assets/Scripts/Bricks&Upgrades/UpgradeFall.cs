using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeFall : MonoBehaviour
{
    [SerializeField] GameObject[] Upgrades;
    int selectUpgrade;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Touched Player");

        selectUpgrade = Random.Range(0, Upgrades.Length);
        Upgrades[selectUpgrade].SetActive(true);
        gameObject.SetActive(false);
    }
}