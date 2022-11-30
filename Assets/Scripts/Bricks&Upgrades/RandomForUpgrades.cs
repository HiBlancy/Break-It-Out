using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForUpgrades : MonoBehaviour
{
    public static RandomForUpgrades Obj { get; private set; }

    [SerializeField] GameObject[] Upgrades;
    int selectUpgrade;
    void Awake()
    {
        if (Obj != null && Obj != this)
            Destroy(this);
        else
            Obj = this;
    }
    public void RandomUpgrade()
    {
        Debug.Log("Arrived");
        selectUpgrade = Random.Range(0, Upgrades.Length);
        Upgrades[selectUpgrade].SetActive(true);
    }
}