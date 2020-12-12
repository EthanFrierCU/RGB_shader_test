using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_wmouse : MonoBehaviour
{
    public float rotateSpeed = 20f;
    public bool grabbed;

    void Start()
    {
        grabbed = false;
    }

    private void OnMouseDrag()
    {
        grabbed = true;

        float rotX = Input.GetAxis("Mouse X") * rotateSpeed;
        float rotY = Input.GetAxis("Mouse Y") * rotateSpeed;

        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, rotY);

    }

    private void OnMouseUp()
    {
        grabbed = false;
    }


    //void Update()
    //{

    //}
}
