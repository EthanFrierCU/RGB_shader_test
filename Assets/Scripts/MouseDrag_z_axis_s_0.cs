using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag_z_axis_s_0 : MonoBehaviour
{
    public float dragSpeed = .01f;
    public float minZ = -.75f;
    public float maxZ = .25f;
    private Vector3 lastMousePos;
    public MouseDrag_z_axis_s_5 selector5;
    public float faceZ0;
    private float offsetDistance = .25f;
    private float minimumDistance = .1f;


    private void Start()
    {
        faceZ0 = -.5f;
    }

    void OnMouseDown()
    {
        lastMousePos = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 delta = Input.mousePosition - lastMousePos;
        Vector3 pos = transform.localPosition;

        pos.z += delta.x * dragSpeed;
        pos.z = Mathf.Clamp(pos.z, minZ, maxZ);

        faceZ0 = pos.z + offsetDistance;

        if (faceZ0 < selector5.faceZ5 - minimumDistance)
        {
            transform.localPosition = pos;
            lastMousePos = Input.mousePosition;
        }
         
    }

}
