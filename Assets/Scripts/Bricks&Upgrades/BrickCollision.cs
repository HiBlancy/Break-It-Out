using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCollision : MonoBehaviour
{
    int posibilityForUpgrade;

    public GameObject myPrefabUpgrade;

    void OnCollisionEnter2D(Collision2D collision)
    {
        BrickCountOnScreen.Obj.BlocksDestroyed();

        posibilityForUpgrade = Random.Range(0, 4);

        if (posibilityForUpgrade == 0)
        {
            Instantiate(myPrefabUpgrade, transform.localPosition, Quaternion.identity);
        }
        gameObject.SetActive(false);
    }
}