using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    private Vector3 initialPosition;
	// Use this for initialization
	void Start () {
        initialPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(initialPosition.x + Mathf.Sin(Time.time) * 2.0f, initialPosition.y, initialPosition.z);
	}
}
