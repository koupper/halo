using UnityEngine;
using System.Collections;

public class ManagerBullet : MonoBehaviour {

    // Use this for initialization
    public GameObject[] bullets;
	void Start () {
       // GameObject clon = Instantiate(bullets[0], new Vector3( transform.position.x + 5, transform.position.y + 5, transform.position.z), transform.rotation) as GameObject;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp("space"))
        {
            GameObject clon = Instantiate(bullets[0], new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), transform.rotation) as GameObject;
            Destroy(clon, 1.1f);
        }
    }
}
