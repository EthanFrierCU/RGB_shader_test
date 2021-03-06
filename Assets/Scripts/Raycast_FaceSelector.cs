﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast_FaceSelector : MonoBehaviour
{
    public Material activeMaterial;
    public Material defaultMaterial;
    public string kind = "face";
    private Transform _selection;
    public bool clicked;
    public GameObject thisFace;
    public float opposing;


    // Start is called before the first frame update
    void Start()
    {
        clicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null && !clicked)
        {
            var selectionRenderer = thisFace.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;

            _selection = null;
        }


        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        LayerMask selector = LayerMask.GetMask("Selectors");

        if (Physics.Raycast(ray, out hit, 10, selector))
        { 
            var selection = hit.transform;


            if (selection.CompareTag(kind))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();


                if (selectionRenderer != null)
                {
                    selectionRenderer.material = activeMaterial;
                }


                _selection = selection;

            }

        }
            
    }

    private void OnMouseDown()
    {
        clicked = true;
    }

    private void OnMouseUp()
    {
        clicked = false;
    }
}
