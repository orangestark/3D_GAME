using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chushigravity : MonoBehaviour
{
    private bool firsttime;
    public string[] objectNames;
    private GameObject[] objects;

    void Start()
    {
        firsttime = true;
        objects = new GameObject[objectNames.Length];

        for (int i = 0; i < objectNames.Length; i++)
        {
            objects[i] = GameObject.Find(objectNames[i]);

            if (objects[i] == null)
            {
                Debug.LogWarning("GameObject with name " + objectNames[i] + " not found!");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (firsttime)
            {
                foreach (GameObject obj in objects)
                {
                    GravityControl cubeRigidbody = obj.GetComponent<GravityControl>();
                    cubeRigidbody.forceDirection = new Vector3(0, 1f, 0);
                    firsttime = false;
                }     
            }

        }

        
    }
}
