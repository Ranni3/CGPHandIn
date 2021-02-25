using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSound : MonoBehaviour
{
    public AudioClip playSound;
    public float Volume;
    AudioSource audio;
    public bool alreadytriggered = false;

    private void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!alreadytriggered)
        {
            audio.PlayOneShot(playSound, Volume);
            alreadytriggered = true;
        }
    }

}
