using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sum : MonoBehaviour {
    public GameObject Player;
    private Rigidbody PlayerRigid;
    public float Upspeed;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                PlayerRigid.AddForce(transform.up * 130);
            }
        }
    }
}
