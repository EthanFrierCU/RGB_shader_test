using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face_Cutter : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 6.33f);
        Vector3 facePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        facePosition.z = transform.position.z;
        transform.position = new Vector3(0, 0, facePosition.z);
    }

}
