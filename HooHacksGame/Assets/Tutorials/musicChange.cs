using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class musicChange : MonoBehaviour{
    public AudioClip otherClip;
    public Transform playerPos;

    // Start is called before the first frame update
    IEnumerator Start(){
        AudioSource audio = GetComponent<AudioSource>();
        float pos = playerPos.position.x;
        Debug.Log(pos);
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        if(pos > 5.0){
            audio.clip = otherClip;
            audio.Play();
        }
    }
}
