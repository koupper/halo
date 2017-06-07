using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaUnguy : MonoBehaviour {
    public bool bulletT;
    public int vida;
    bool isLive;
   
    // Use this for initialization
    void Start () {
        vida = 60;
        isLive = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (isLive)
        {
            if (bulletT)
            {
                if (vida <= 0)
                {
                    isLive = false;
                }
                else
                {
                    vida = vida - 20;
                    bulletT = false;
                    
                }
            }
        }
        else
        {
            Destroy(transform.gameObject);
        }


    }
    void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.tag == "basicShoot")
        {
            // Debug.Log(colision.gameObject.name);
            bulletT = true;
        }

    }
}
