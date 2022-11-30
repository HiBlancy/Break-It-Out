using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBigger : MonoBehaviour
{
    Transform player;
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        PlayerGetsBigger();
    }
    void PlayerGetsBigger()
    {
        Debug.Log("bigger");
        player.transform.localScale = new Vector2(PlayerScale.Obj.scale + 0.5f, 0.2f);
        StartCoroutine(DesactivateThis());
    }

    IEnumerator DesactivateThis()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }
}