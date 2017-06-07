using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    public GameObject spartan;
    private float posCamera;

    // Use this for initialization
    void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {
        posCamera = spartan.transform.position.x;
        transform.position = new Vector3( 5.5f + posCamera, 0, -10);
        
        

    }
}
