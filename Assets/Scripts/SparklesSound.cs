using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparklesSound : MonoBehaviour
{
    private float timer = 1.5f;
    private float time = 0.0f;
    private AudioSource aSource;

    private void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        time += Time.deltaTime;

        if (time >= timer)
        {
            aSource.pitch = Random.Range(0.5f, 1.5f);

            time = 0.0f;
        }
    }
}
