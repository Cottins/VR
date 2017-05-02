using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnBaloons : MonoBehaviour
{
    public GameObject baloon;
    // Use this for initialization
    void Awake ()
    {
        Instantiate(baloon, new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z), Quaternion.identity);
	}
    
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Baloon")
        {
            Instantiate(baloon, new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z), Quaternion.identity);
        }
    }
}
