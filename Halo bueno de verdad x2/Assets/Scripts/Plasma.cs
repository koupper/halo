using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plasma : MonoBehaviour {
    public Transform bullet;
    public float velocidad;
   public GameObject Spartan;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bullet.Translate((velocidad * new Vector2(-2, 0)) * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D colision)
    {
        Debug.Log(colision.gameObject.name);
        if (colision.gameObject.name == "Spartan")
        {
            Destroy(transform.gameObject,0.05f);

        }
    }
}
