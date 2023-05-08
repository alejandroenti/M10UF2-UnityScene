using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] jumpClips;

    public void PlayJumpAudio()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.volume = Random.Range(0.9f, 1.0f);
        aSource.pitch = Random.Range(0.8f, 1.2f);
        aSource.PlayOneShot(jumpClips[Random.Range(0, jumpClips.Length)]);
    }
}
