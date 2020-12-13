using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_cut_selectors : MonoBehaviour
{

    public GameObject selector0;
    public GameObject selector1;
    public GameObject selector2;
    public GameObject selector3;
    public GameObject selector4;
    public GameObject selector5;

    public float distanceOffset = .5f;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Scale();

    }

    void Scale()
    {
        float distanceX = Vector3.Distance(selector2.transform.localPosition, selector3.transform.localPosition );
        float distanceY = Vector3.Distance(selector1.transform.localPosition , selector4.transform.localPosition );
        float distanceZ = Vector3.Distance(selector0.transform.localPosition , selector5.transform.localPosition );

        float middleX = (selector2.transform.localPosition.x + selector3.transform.localPosition.x) / 2;
        float middleY = (selector1.transform.localPosition.y + selector4.transform.localPosition.y) / 2;
        float middleZ = (selector0.transform.localPosition.z + selector5.transform.localPosition.z) / 2;

        transform.localScale = new Vector3(distanceX - distanceOffset, distanceY - distanceOffset, distanceZ - distanceOffset);

        transform.localPosition = new Vector3(middleX, middleY, middleZ);
        


    }
}
