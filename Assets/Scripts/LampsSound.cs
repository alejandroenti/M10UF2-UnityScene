using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampsSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] lampClips;
    [SerializeField] private AudioSource aSource;

    private float timer;
    private float time;

    private void Start()
    {
        aSource = GetComponent<AudioSource>();
        timer = Random.Range(0.5f, 2.0f);
    }

    private void Update()
    {
        time += Time.deltaTime;

        if (time >= timer)
        {
            aSource.volume = Random.Range(0.8f, 0.9f);
            aSource.pitch = Random.Range(0.9f, 1.1f);
            aSource.PlayOneShot(lampClips[Random.Range(0, lampClips.Length)]);

            timer = Random.Range(0.5f, 2.0f);
            time = 0.0f;
        }
    }
}
