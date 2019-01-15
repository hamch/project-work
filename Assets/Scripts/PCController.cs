﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCController : MonoBehaviour {
    public float speed = 10.0f;
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(x * speed, 0, z * speed);
    }
}
