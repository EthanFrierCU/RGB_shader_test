using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testscreentoworldpoint : MonoBehaviour

{
    private Camera cam;
    public float x = 0;
    public float y = 0;
    public float z = 0;


    void Start()
    {
        //cam = Camera.main;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                var selected = hit.transform;
                if (selected.CompareTag("face"))
                {

                    Debug.Log(hit.point);
                    //Vector3 testdebug = Vector3.zero;
                    //testdebug.x = hit.point.x;
                    //testdebug.y = hit.point.y;
                    //testdebug.z = hit.point.z;
                    //Debug.LogError('selected', testdebug);
                    Debug.DrawRay(ray.origin, hit.point);

                }

            }

        }

        
    }



        //    if (Input.GetButtonDown("Fire1"))
        //    {
        //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //        RaycastHit hit;

        //        if (Physics.Raycast(ray, out hit))
        //        {

        //            if (hit.collider.tag == "face")
        //            {
        //                Debug.DrawRay(ray.origin, ray.direction);
        //                Debug.Log(hit);

        //            }

        //        }


        //    }




        //Vector3 point = new Vector3();
        //Event currentEvent = Event.current;
        //Vector2 mousePos = new Vector2();

        //mousePos.x = Input.GetAxis("Mouse X");
        //mousePos.y = Input.GetAxis("Mouse Y");

        //point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 3));

        //Debug.Log("Screen pixels: " + cam.pixelWidth + ":" + cam.pixelHeight);
        //Debug.Log("Mouse position: " + mousePos);
        //Debug.Log("World position: " + point.ToString("F3"));

    //}
}


