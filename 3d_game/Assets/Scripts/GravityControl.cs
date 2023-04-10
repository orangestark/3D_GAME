using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    public float raycastDistance = 100f;
    public LayerMask mask;

    private void Start()
    {
        Physics.gravity = new Vector3(0,9.81f,0);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2f, Screen.height/2f, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, raycastDistance,mask))
            {
                Debug.Log("Hit gameobject: " + hit.collider.gameObject.name);
                //hit.transform.GetComponent<Renderer>().material.color = Color.red;
                Physics.gravity = Physics.gravity * -1;
            }
        }
    }
}
