using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag_z_axis : MonoBehaviour
{
    public float dragSpeed = .001f;
    public float minZ;
    public float maxZ;
    private Vector3 lastMousePos;
    public MouseDrag_z_axis opposing;
    public float faceZ;
    private float offsetDistance = .25f;
    private float debugFace;

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

        faceZ = pos.z + offsetDistance;

        transform.localPosition = pos;
        lastMousePos = Input.mousePosition;

        Debug.Log("pos.z" + pos.z);
        Debug.Log("faceZ" + faceZ);

    }

    private void Update()
    {
      
    }

}
