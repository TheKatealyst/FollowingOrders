using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioSource SFXClip1;
    public AudioSource SFXClip2;
    public AudioSource SFXClip3;

    void Update()
    {
        if (Input.GetKeyDown("5"))
        {
            SFXClip1.Play();
        }
        if (Input.GetKeyDown("6"))
        {
            SFXClip2.Play();
        }
        if (Input.GetKeyDown("7"))
        {
            SFXClip3.Play();
        }
    }

    public void PlaySFX1()
    {
        SFXClip1.Play();
    }

    public void PlaySFX2()
    {
        SFXClip2.Play();
    }
}