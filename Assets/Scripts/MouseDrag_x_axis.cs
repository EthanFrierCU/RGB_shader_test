using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag_x_axis : MonoBehaviour
{
    public float dragSpeed = .001f;
    public float minX = -1;
    public float maxX = 1;
    private Vector3 lastMousePos;

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
        transform.localPosition = pos;
        lastMousePos = Input.mousePosition;
    }
}