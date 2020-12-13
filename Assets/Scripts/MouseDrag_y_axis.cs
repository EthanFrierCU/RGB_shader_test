using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag_y_axis : MonoBehaviour
{
    public float dragSpeed = .001f;
    public float minY = -2;
    public float maxY = 2;
    private Vector3 lastMousePos;

    void OnMouseDown()
    {
        lastMousePos = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector3 delta = Input.mousePosition - lastMousePos;
        Vector3 pos = transform.position;
        pos.y += delta.y * dragSpeed;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
        lastMousePos = Input.mousePosition;
    }
}

