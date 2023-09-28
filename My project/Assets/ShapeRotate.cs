using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeRotate : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start");
    }

    float Rotate_Speed = 90f;
    void Update()
    {
        transform.Rotate(Vector3.forward * Rotate_Speed * Time.deltaTime);
    }
}
