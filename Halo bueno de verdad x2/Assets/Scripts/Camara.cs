using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {
    public GameObject player;
    private float posCamera;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        posCamera = player.transform.position.x;
        transform.position = new Vector3(5.5f + posCamera, 0, -10);

    }
}
