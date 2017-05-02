using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearTargetScript : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Baloon")
        {
            GameObject.FindObjectOfType<ScoreManager>().score += 5;
            Destroy(other.gameObject);
        }
    }
}
