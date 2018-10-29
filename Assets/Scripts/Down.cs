using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour {
    public float totalTime;
    public int seconds;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        Debug.Log("totalTime"); 
	}
    
}
