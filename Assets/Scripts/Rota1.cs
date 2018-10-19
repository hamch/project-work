using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rota1 : MonoBehaviour {
    public float lotatespeed = 1f;
    public float lotaspeed = 0f;
    public float lospeed = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(lotaspeed, lotatespeed, lospeed));
	}
}
