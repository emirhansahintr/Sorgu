using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollWheel : MonoBehaviour
{
    [Range(20,100)]
    public float speed=100f;


    void Update()
    {
        float Scroll=Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * speed;
        transform.Translate(Vector3.forward* Scroll);
    }
}
