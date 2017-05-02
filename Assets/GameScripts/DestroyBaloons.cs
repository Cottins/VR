using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBaloons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(transform.position.z >= 25)
        {
            Destroy(gameObject);
        }
	}
}
