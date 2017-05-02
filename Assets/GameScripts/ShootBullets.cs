using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour
{
    public GameObject bullet;

    bool spawn;
    bool startTime;

    //float xPos, yPos, zPos = 0;

    float time = 0.0f;

	// Use this for initialization
	void Start ()
    {
        //xPos = Random.Range(-2, 2);
        //zPos = Random.Range(-2, 2);
        //yPos = Random.Range(transform.position.y, transform.position.y + 2);
        startTime = true;
	}

    void Update()
    {
        
        if (startTime)
        {
            time += Time.deltaTime;
        
            if (time >= 7)
            {
                startTime = false;
                Spawn();
            }
        }
    }

    void Spawn()
    {
        float xPos = Random.Range(-1, 1);
        float zPos = Random.Range(-1, 1);
        float yPos = Random.Range(transform.position.y, transform.position.y + 2);
        float xPos1 = Random.Range(-1, 1);
        float zPos1 = Random.Range(-1, 1);
        float yPos1 = Random.Range(transform.position.y, transform.position.y + 2);
        float xPos2 = Random.Range(-1, 1);
        float zPos2 = Random.Range(-1, 1);
        float yPos2 = Random.Range(transform.position.y, transform.position.y + 2);
        int time = Mathf.RoundToInt(Random.Range(5.0f, 15.0f));
        Instantiate(bullet, new Vector3(xPos, yPos, zPos), Quaternion.identity);
        Instantiate(bullet, new Vector3(xPos1, yPos1, zPos1), Quaternion.identity);
        Instantiate(bullet, new Vector3(xPos2, yPos2, zPos2), Quaternion.identity);
        Invoke("Spawn", time);
    }
}
