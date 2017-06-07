using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaManager : MonoBehaviour {
    public GameObject[] bullets;
    GameObject clon;
    public float tiempoT,tiempoA, tiempoR;
    

    // Use this for initialization
    void Start () {
        tiempoR = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
        tiempoT = Time.time;
        tiempoA = tiempoT - tiempoR;
        if (tiempoA >= 1.6f)
        {
            tiempoR = tiempoT;
             clon = Instantiate(bullets[0], new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), transform.rotation) as GameObject;
            Destroy(clon, 1.1f);
             
        }
       

    }
}
