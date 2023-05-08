using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] foostepsOnGrass;
    [SerializeField] private string material;

    void PlayFoostepSound()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.volume = Random.Range(0.9f, 1.0f);
        aSource.pitch = Random.Range(0.8f, 1.2f);

        switch (material)
        {

            case "Grass":
                if (foostepsOnGrass.Length > 0)
                    aSource.PlayOneShot(foostepsOnGrass[Random.Range(0, foostepsOnGrass.Length)]);
                break;

            default:
                break;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Grass":
                material = collision.gameObject.tag;
                break;

            default:
                material = "";
                break;
        }
    }
}
