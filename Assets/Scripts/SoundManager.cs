using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip hit, playerDeath;
    static AudioSource audioSrc;

    void Start()
    {
        hit = Resources.Load<AudioClip> ("BumpSFX");
        playerDeath = Resources.Load<AudioClip> ("DropSFX");
        audioSrc = GetComponent<AudioSource> ();
    }

    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip){
            case "BumpSFX":
                audioSrc.PlayOneShot (hit);
            break;
            case "DropSFX":
                audioSrc.PlayOneShot (playerDeath);
            break;
        }
    }
}
