using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollider : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            GameObject.FindObjectOfType<ScoreManager>().score -= 50;
            Destroy(other.gameObject);
        }
    }
}
