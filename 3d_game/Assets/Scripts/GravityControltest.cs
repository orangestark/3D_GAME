using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControltest : MonoBehaviour
{
    public float raycastDistance = 100f;
    public LayerMask mask;
    private Rigidbody rb;
    public Collider coll;
    
    private float forceMagnitude = 9.81f;
    [SerializeField]
    private Vector3 forceDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
        //Physics.gravity = new Vector3(0,9.81f,0);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2f, Screen.height/2f, 0));
            RaycastHit hit;

            if (coll.Raycast(ray, out hit, raycastDistance))
            {
                Debug.Log("Hit gameobject: " + hit.collider.gameObject.name);
                //hit.transform.GetComponent<Renderer>().material.color = Color.red;
                forceDirection = -forceDirection;
                FindObjectOfType<audiomanager>().Play("changegravity");
            }
        }
        rb.AddForce(forceMagnitude * forceDirection, ForceMode.Force);
    }
}
