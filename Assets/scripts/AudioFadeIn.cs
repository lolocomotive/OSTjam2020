using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFadeIn : MonoBehaviour
{
    public float currentVolume;
    public AudioSource source;
    public float fadeTime;
    public float startTime;
    // Start is called before the first frame update
    void Awake()
    {
        currentVolume = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.realtimeSinceStartup > startTime)
        {
            if (!source.isPlaying)
            {
                source.Play();
            }
            currentVolume += Mathf.Clamp(Time.deltaTime / fadeTime, 0, 1);
            source.volume = currentVolume;
        }
    }
}
