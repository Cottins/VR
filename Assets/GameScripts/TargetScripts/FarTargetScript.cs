using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarTargetScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Baloon")
        {
            GameObject.FindObjectOfType<ScoreManager>().score += 20;
            Destroy(other.gameObject);
        }
    }
}
