using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundShoot : MonoBehaviour
{
    public AudioClip fire;
	// Use this for initialization
	void Start ()
    {
        GetComponent<AudioSource>().clip = fire;
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
