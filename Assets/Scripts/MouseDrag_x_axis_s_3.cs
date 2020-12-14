using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag_x_axis_s_3 : MonoBehaviour
{
    private float dragSpeed = .01f;
    private float minX = -.75f;
    private float maxX = .25f;
    private Vector3 lastMousePos;
    public MouseDrag_x_axis_s_2 selector2;
    public float faceX3;
    private float offsetDistance = .25f;
    private float minimumDistance = .1f;


    private void Start()
    {
        faceX3 = -.5f;
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

        faceX3 = pos.x + offsetDistance;

        if (faceX3 < selector2.faceX2 - minimumDistance)
        {
            transform.localPosition = pos;
            lastMousePos = Input.mousePosition;
        }

    }
}