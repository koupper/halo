using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {
    public Transform bullet;
    public float velocidad;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        bullet.Translate((velocidad * new Vector2(2, 0)) * Time.deltaTime);

    }
}
