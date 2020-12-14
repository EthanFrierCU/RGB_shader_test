using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag_y_axis_s_1 : MonoBehaviour
{
    private float dragSpeed = .01f;
    private float minY = -.25f;
    private float maxY = .75f;
    private Vector3 lastMousePos;
    public MouseDrag_y_axis_s_4 selector4;
    public float faceY1 = .5f;
    private float offsetDistance = .25f;
    private float minimumDistance = .1f;


    private void Start()
    {
        faceY1 = .5f;
    }

    void OnMouseDown()
    {
        lastMousePos = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 delta = Input.mousePosition - lastMousePos;
        Vector3 pos = transform.localPosition;

        pos.y += delta.y * dragSpeed;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        faceY1 = pos.y - offsetDistance;

        if (faceY1 > selector4.faceY4 + minimumDistance)
        {
            transform.localPosition = pos;
        }

        lastMousePos = Input.mousePosition;


    }
}

