using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectUpgrade : MonoBehaviour
{
    public static SelectUpgrade Obj { get; private set; }

    [SerializeField] GameObject[] Upgrades;
    int selectUpgrade;

    void Awake()
    {
        if (Obj != null && Obj != this)
            Destroy(this);
        else
            Obj = this;
    }

    public void CallingUpgrade()
    {
        Debug.Log("Selecting");
        selectUpgrade = Random.Range(0, Upgrades.Length);
        Upgrades[selectUpgrade].SetActive(true);
    }
}