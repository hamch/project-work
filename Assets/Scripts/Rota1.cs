using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rota1 : MonoBehaviour {
    public float lotatespeed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, lotatespeed, 0));
	}
}
