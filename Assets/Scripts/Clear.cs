using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
