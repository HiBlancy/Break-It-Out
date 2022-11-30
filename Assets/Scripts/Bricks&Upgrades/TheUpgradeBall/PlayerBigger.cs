using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBigger : MonoBehaviour
{
    Transform player;

   // GameObject theUpgrates;

    void OnEnable()
    {
        Debug.Log("bigger");
    //    theUpgrates.GetComponent<UpgradeFall>().enabled = true;
        PlayerScale.Obj.scale = PlayerScale.Obj.scale + 0.5f;
        gameObject.SetActive(false);
    }

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    //    theUpgrates = GameObject.FindWithTag("Upgrade");
    }
}