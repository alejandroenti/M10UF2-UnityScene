using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CricketsSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] cricketsClips;
    [SerializeField] private AudioSource aSource;

    private void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!aSource.isPlaying) {
            aSource.volume = Random.Range(0.7f, 0.95f);
            aSource.pitch = Random.Range(0.7f, 1.3f);
            aSource.PlayOneShot(cricketsClips[Random.Range(0, cricketsClips.Length)]);
        }
    }
}
