using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeFall : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }
}