using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSound : MonoBehaviour {
    public AudioClip[] audioClips;
    private int counter = 0;
    private bool pressed = false;
    // Use this for initialization
    void Start () {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = audioClips[counter];
        audio.Play();
    }
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("nextMusic");

        if (x != 0)
        {
            pressed = true;
            counter++;
            if(counter+1 > audioClips.Length)
            {
                counter = 0;
            }
        }
        if (x == 0)
        {
            pressed = false;
        }

        if (pressed)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = audioClips[counter];
            audio.Play();
        }
    }
}
