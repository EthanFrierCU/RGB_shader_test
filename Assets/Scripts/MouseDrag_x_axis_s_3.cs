using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag_x_axis_s_3 : MonoBehaviour
{
    private float minX = -.75f;
    private float maxX = .25f;
    public MouseDrag_x_axis_s_2 selector2;
    public float faceX3;
    private float offsetDistance = .25f;
    private float minimumDistance = .1f;
    private Vector3 screenPoint;
    private Vector3 offset;


    private void Start()
    {
        faceX3 = -.5f;
    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }


    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;

        curPosition.x = Mathf.Clamp(curPosition.x, minX, maxX);
        curPosition.y = 0;
        curPosition.z = 0;

        faceX3 = curPosition.x + offsetDistance;

        if (faceX3 < selector2.faceX2 - minimumDistance)
        {
            transform.localPosition = curPosition;
        }

    }
}