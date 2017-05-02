using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    public GameObject[] launchers;
    public GameObject bullet;
    float timer;
	// Use this for initialization
	void Start ()
    {
        timer = 10;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            timer = Random.Range(10.0f, 20.0f);
            Shoot();
        }
	}

    void Shoot()
    {
        GameObject platform = launchers[Random.Range(0, launchers.Length)];
        Instantiate(bullet, new Vector3(platform.transform.position.x, platform.transform.position.y, platform.transform.position.z), Quaternion.identity);
    }
}
