using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelicanMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y >= 2.64)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.01f, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x- 2f, transform.position.y+0.05f, transform.position.z);
        }
		
	}
}
