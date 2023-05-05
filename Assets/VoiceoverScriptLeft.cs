using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceoverScriptLeft : MonoBehaviour
{
    AudioSource myClip;
    // Start is called before the first frame update
    void Start()
    {
        myClip = GetComponent<AudioSource>();
    }

   
    void OnTriggerEnter(Collider collider)
    {
        myClip.Play();
    }
}

