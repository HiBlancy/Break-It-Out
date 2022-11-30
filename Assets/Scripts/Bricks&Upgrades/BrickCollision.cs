using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCollision : MonoBehaviour
{
    int posibilityForUpgrade;

    public GameObject myPrefabUpgrade;

    public int giveScore = 100;

    void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreManager.Obj.AddScore(giveScore);
        BrickCountOnScreen.Obj.BlocksDestroyed();

        posibilityForUpgrade = Random.Range(0, 4);

        Debug.Log(posibilityForUpgrade);
        if (posibilityForUpgrade == 0)
        {
            Instantiate(myPrefabUpgrade, transform.localPosition, Quaternion.identity);
        }
        gameObject.SetActive(false);
    }
}