using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag_y_axis_s_1 : MonoBehaviour
{
    private float minY = -.25f;
    private float maxY = .75f;
    public MouseDrag_y_axis_s_4 selector4;
    public float faceY1 = .5f;
    private float offsetDistance = .25f;
    private float minimumDistance = .1f;
    private Vector3 screenPoint;
    private Vector3 offset;


    private void Start()
    {
        faceY1 = .5f;
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

        curPosition.x = 0;
        curPosition.y = Mathf.Clamp(curPosition.y, minY, maxY);
        curPosition.z = 0;

        faceY1 = curPosition.y - offsetDistance;

        if (faceY1 > selector4.faceY4 + minimumDistance)
        {
            transform.localPosition = curPosition;
        }

    }

}

