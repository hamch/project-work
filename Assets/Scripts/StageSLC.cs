﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSLC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    void Update()
    {
        if (Input.touchCount > 0)
        {
            SceneManager.LoadScene("STGsl");
        }
    }
    // Update is called once per frame
    
}
