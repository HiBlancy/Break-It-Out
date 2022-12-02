using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishedSound : MonoBehaviour
{
    AudioSource audioFinal;
    void Start()
    {
        audioFinal = GetComponent<AudioSource>();

        audioFinal.Play();
    }
}