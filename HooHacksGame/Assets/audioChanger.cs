using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class audioChanger : MonoBehaviour
{
    public AudioClip otherClip;
    public Transform xPos;

    IEnumerator Start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        audio.Play();
        yield return new WaitForSeconds(5);
        if(xPos.position.x > 5){
            audio.clip = otherClip;
            audio.Play();
        }
    }
}
