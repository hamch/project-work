using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    public float speed = 10.0f;

    void FixedUpdate()
    {
        Vector3 dir= transform.position;
        dir.x += Input.acceleration.x * speed;
        dir.z += Input.acceleration.y * speed;
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.MovePosition(dir);
    }
}
