using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor5 : MonoBehaviour
{
    public int power = 0;
    bool fade = false;
    bool startTimer;
    float timer;

    void Start()
    {
        timer = 1.7f;
    }

    // Update is called once per frame
    void Update()
    {
        if (fade)
        {
            if (power > 0)
            {
                power -= 5;
                Sending.sensor5(power);
            }
            if (power <= 0)
            {
                power = 0;
                fade = false;
                Sending.sensor5(power);
            }
        }

        if (startTimer)
        {
            timer -= Time.deltaTime;
            
            
        }
        if (timer <= 0)
        {
            Sending.sensor5(0);
            startTimer = false;
            timer = 1.7f;
        }

    }

    void OnCollisionEnter(Collision other)
    {
        //Debug.Log("collider");
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            power = 100;
            fade = true;
            startTimer = true;
            Sending.sensor1(0);
            Sending.sensor2(0);
            Sending.sensor3(0);
            Sending.sensor4(0);
            Sending.sensor6(0);
        }
        //Sending.sensor5(power);
    }
}
