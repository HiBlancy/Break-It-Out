using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSmaller : MonoBehaviour
{
    Transform player;

    void OnEnable()
    {
        PlayerScale.Obj.scale = PlayerScale.Obj.scale - 0.5f;
        gameObject.SetActive(false);
    }

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }
}