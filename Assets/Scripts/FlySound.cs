using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySound : MonoBehaviour
{
    [SerializeField] private AudioClip flyClip;
    [SerializeField] private AudioClip flyIdleClip;

    public void PlayFlySound()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.PlayOneShot(flyClip);
    }

    public void PlayFlyIdleSound()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.PlayOneShot(flyIdleClip);
    }
}
