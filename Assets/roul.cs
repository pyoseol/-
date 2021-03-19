using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roul : MonoBehaviour
{
    float rotSpeed = 0.0f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            this.rotSpeed = 5.0f;
        }

        if (Input.GetMouseButtonDown(1))
        {
           this.rotSpeed = 0.0f;
        }

        this.rotSpeed *= 0.987f;
        transform.Rotate(0, 0, this.rotSpeed);
    }
}
