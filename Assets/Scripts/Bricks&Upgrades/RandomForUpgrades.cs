using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForUpgrades : MonoBehaviour
{
    public static RandomForUpgrades Obj { get; private set; }

    [SerializeField] GameObject[] Upgrades;
    int selectUpgrade;

    public GameObject myPrefabUpgrade;

    void Awake()
    {
        if (Obj != null && Obj != this)
            Destroy(this);
        else
            Obj = this;
    }

    public void RandomUpgrade()
    {
        Debug.Log("Arrived to upgrade script");
        selectUpgrade = Random.Range(0, Upgrades.Length);
        Upgrades[selectUpgrade].SetActive(true);

        Instantiate(myPrefabUpgrade, new Vector2(0, 0), Quaternion.identity);

        //hay que hacer que se instance sobre la posicion dende se destruye el bloque cambiar el new vector2
    }
}