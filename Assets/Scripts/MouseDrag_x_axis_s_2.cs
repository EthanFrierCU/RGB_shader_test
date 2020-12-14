using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag_x_axis_s_2 : MonoBehaviour
{
    private float dragSpeed = .01f;
    private float minX = -.25f;
    private float maxX = .75f;
    private Vector3 lastMousePos;
    public MouseDrag_x_axis_s_3 selector3;
    public float faceX2;
    private float offsetDistance = .25f;
    private float minimumDistance = .1f;


    private void Start()
    {
        faceX2 = .5f;
    }

    void OnMouseDown()
    {
        lastMousePos = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 delta = Input.mousePosition - lastMousePos;
        Vector3 pos = transform.localPosition;

        pos.x += delta.x * dragSpeed;
        pos.x = Mathf.Clamp(pos.x, minX, maxX);

        faceX2 = pos.x - offsetDistance;

        if (faceX2 > selector3.faceX3 + minimumDistance)
        {
            transform.localPosition = pos;
            lastMousePos = Input.mousePosition;
        }

    }
}