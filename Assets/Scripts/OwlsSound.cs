using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlsSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] owlsClips;
    [SerializeField] private AudioSource aSource;

    private float timer;
    private float time;

    void Start()
    {
        aSource = GetComponent<AudioSource>();

        timer = Random.Range(1.0f, 15.0f);
        time = 0.0f;
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= timer)
        {
            aSource.volume = Random.Range(0.8f, 0.9f);
            aSource.pitch = Random.Range(0.9f, 1.1f);
            aSource.PlayOneShot(owlsClips[Random.Range(0, owlsClips.Length)]);

            timer = Random.Range(1.0f, 15.0f);
            time = 0.0f;
        }
    }
}
