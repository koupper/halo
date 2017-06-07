﻿using UnityEngine;
using System.Collections;

public class SpartanMovement : MonoBehaviour {
    public Animator anim;
    public Transform spartan;
    public float velocidad;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            anim.SetBool("jump", true);
            if (anim.GetBool("walkDer"))
            {
                spartan.Translate((velocidad * new Vector2(2, 3)) * Time.deltaTime);
            }
            else if (anim.GetBool("walkIzq"))
            {
                if (spartan.transform.position.x >= -12.59067)
                {
                    spartan.Translate((velocidad * new Vector2(-2, 3)) * Time.deltaTime);
                }
            }
            else
            {
                spartan.Translate((velocidad * new Vector2(0, 3)) * Time.deltaTime);
            }
        }
        else
        {
            anim.SetBool("jump", false);
            if (Input.GetKey("d"))
            {
                spartan.Translate((velocidad* new Vector2(2,0))*Time.deltaTime);
                anim.SetBool("walkDer", true);
                anim.SetBool("walkIzq", false);
                anim.SetBool("stand", false);
                anim.SetBool("shoot", false);
            }
            else if (Input.GetKey("a"))
            {
                if (spartan.transform.position.x >= -12.59067)
                {
                    spartan.Translate((velocidad * new Vector2(-2, 0)) * Time.deltaTime);
                    anim.SetBool("walkIzq", true);
                    anim.SetBool("walkDer", false);
                    anim.SetBool("stand", false);
                    anim.SetBool("shoot", false);
                }
            }
            else if (Input.GetKey("space"))
            {
                anim.SetBool("walkIzq", false);
                anim.SetBool("walkDer", false);
                anim.SetBool("stand", false);
                anim.SetBool("shoot", true);
            }

            else
            {
                anim.SetBool("walkIzq", false);
                anim.SetBool("walkDer", false);
                anim.SetBool("stand", true);
                anim.SetBool("shoot", false);

            }
        }

	
	}
}