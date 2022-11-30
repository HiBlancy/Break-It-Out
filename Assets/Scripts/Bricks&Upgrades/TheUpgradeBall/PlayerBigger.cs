using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBigger : MonoBehaviour
{
    Transform player;

    void OnEnable()
    {
        Debug.Log("bigger");
        PlayerScale.Obj.scale = PlayerScale.Obj.scale + 0.5f;
        gameObject.SetActive(false);
    }

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
}