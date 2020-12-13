using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag_z_axis : MonoBehaviour
{
    public float dragSpeed = .001f;
    public float minZ = -1;
    public float maxZ = 1;
    private Vector3 lastMousePos;

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
        transform.localPosition = pos;
        lastMousePos = Input.mousePosition;
    }
}
