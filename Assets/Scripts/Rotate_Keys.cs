using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Keys : MonoBehaviour
{
    public float rotateSpeed = 5f;
    public bool grabbed;

    void Start()
    {
        grabbed = false;
    }

    void Update()
    {
        float spinX = Input.GetAxis("Vertical") * rotateSpeed;
        float spinY = Input.GetAxis("Horizontal") * rotateSpeed;

        if (spinX != 0)
        {
            grabbed = true;
            transform.Rotate(Vector3.right, spinX);
        }
        else if (spinY != 0)
        {
            grabbed = true;
            transform.Rotate(Vector3.up, -spinY);
        }
        else if (spinX == 0 && spinY == 0)
        {
            grabbed = false;
        }

    }
}
