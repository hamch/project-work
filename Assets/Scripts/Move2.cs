using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public float x1 = 0f;
    public float y1 = 0f;
    public float z1 = 0f;
    private Vector3 initialPosition;
    // Use this for initialization
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(initialPosition.x + Mathf.Sin(Time.time) * x1, initialPosition.y + Mathf.Sin(Time.time) * y1, initialPosition.z + Mathf.Sin(Time.time) * z1);
    }
}
