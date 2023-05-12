using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicChange : MonoBehaviour
{
    public AudioMixerSnapshot baseSnapshot;
    public AudioMixerSnapshot nearHousesSnapshot;
    public AudioMixerSnapshot indoorSnapshot;

    public float transitionTimeFast = 0.25f;
    public float transitionTimeSlow = 1.00f;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "NearHouses")
            nearHousesSnapshot.TransitionTo(transitionTimeSlow);

        if (collider.gameObject.tag == "Indoor")
            indoorSnapshot.TransitionTo(transitionTimeSlow);
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Indoor")
            nearHousesSnapshot.TransitionTo(transitionTimeFast);

        if (collider.gameObject.tag == "NearHouses")
            baseSnapshot.TransitionTo(transitionTimeSlow);
    }
}