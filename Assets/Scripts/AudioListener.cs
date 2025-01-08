using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Actionsmanager;

public class AudioListener : MonoBehaviour
{
    public AudioSource HoopCheerSound;

    void OnEnable()
    {
        // Subscribe to the basket scored event
        ActionsManager.OnBasketScoredEvent += PlayAudioSource;
    }

    void OnDisable()
    {
        // Unsubscribe from the event
        ActionsManager.OnBasketScoredEvent -= PlayAudioSource;
    }

    private void PlayAudioSource()
    {
        // Play the sound once called
        if (HoopCheerSound != null)
        {
            HoopCheerSound.Play();
        }
    }
}
