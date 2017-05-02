using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidTargetScript : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Baloon")
        {
            GameObject.FindObjectOfType<ScoreManager>().score += 10;
            Destroy(other.gameObject);
        }
    }
}
