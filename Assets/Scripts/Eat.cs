using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    public AudioSource audio;
    
    public void playThisSound()
    {
        audio.Play();
    }
    public void stopThisSound()
    {
        audio.Stop();
    }
}
