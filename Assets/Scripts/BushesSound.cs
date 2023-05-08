using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushesSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] bushesClips;

    void PlayBushesAudio()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.volume = Random.Range(0.9f, 1.0f);
        aSource.pitch = Random.Range(0.8f, 1.2f);
        aSource.PlayOneShot(bushesClips[Random.Range(0, bushesClips.Length)]);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayBushesAudio();
    }
}
