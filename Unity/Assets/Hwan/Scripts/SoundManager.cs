using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public enum EFT_TYPE
    {
        COIN,
        COLLISION,
        CAM_MOVE
        
    }

    public AudioSource eftAudio;

    public AudioClip[] efts;

    private void Awake()
    {
        instance = this;
    }

    public void PlayEFT(EFT_TYPE type)
    {
        eftAudio.PlayOneShot(efts[(int)type]);
    }
}
