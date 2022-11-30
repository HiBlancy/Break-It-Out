using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSmaller : MonoBehaviour
{
    Transform player;
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        PlayerGetsSmaller();
    }
    void PlayerGetsSmaller()
    {
        Debug.Log("smaller");
        PlayerScale.Obj.scale =- 0.5f;
        StartCoroutine(DesactivateThis());
    }
    
    IEnumerator DesactivateThis()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }
}