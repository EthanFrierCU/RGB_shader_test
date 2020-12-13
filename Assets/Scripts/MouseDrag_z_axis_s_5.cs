using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag_z_axis_s_5 : MonoBehaviour
{
    public float dragSpeed = .01f;
    public float minZ = -.25f;
    public float maxZ = .75f;
    private Vector3 lastMousePos;
    public MouseDrag_z_axis_s_0 selector0;
    public float faceZ5 = .5f;
    private float offsetDistance = .25f;
    private float minimumDistance = .1f;


    private void Start()
    {
        faceZ5 = -.5f;
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

        faceZ5 = pos.z - offsetDistance;

        if (faceZ5 > selector0.faceZ0 + minimumDistance)
        {
            transform.localPosition = pos;
            lastMousePos = Input.mousePosition;
        }

    }

}
