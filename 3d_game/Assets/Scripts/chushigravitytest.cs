using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chushigravitytest : MonoBehaviour
{
    private bool firsttime;
    [System.Serializable]
    public class ObjectData
    {
        //public string name;
        public GameObject gameObject;
        public Vector3 force;
    }

    public ObjectData[] objects;

    private void OnTriggerEnter(Collider other)
    {
        firsttime = true;
        if (other.tag == "Player")
        {
            if (firsttime)
            {
                foreach (ObjectData obj in objects)
                {
                    obj.gameObject.GetComponent<GravityControl>().forceDirection = obj.force;
                    
                    firsttime = false;
                }     
            }

        }

        
    }
}
