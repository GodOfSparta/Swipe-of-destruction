using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    public GameObject newcamera;
    AudioSource audioSource;

    void Start()
    {
        audioSource = newcamera.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = gameObject.GetComponent<Slider>().value;
    }
}
