using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XZ : MonoBehaviour {
    public GameObject target;

    float X;
    float Y;
    float Z;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        X = target.transform.position.x;
        Y = target.transform.position.y;
        Z = target.transform.position.z;

        this.GetComponent<Text>().text = "X:" + X.ToString()+ " Y:" + Y.ToString()+ " Z:" + Z.ToString();
	}
}
