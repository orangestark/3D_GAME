using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private CharacterController controller;
    private Vector3 _velocity;
    private bool _isPlayerOn;

    private void Update()
    {
        if (_isPlayerOn)
        {
            _velocity = rb.velocity;
            if (_velocity != new Vector3(0, 0, 0))
            {
                Debug.Log(_velocity);
                controller.Move(_velocity * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player enter platform");
            _isPlayerOn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player exit platform");
            _isPlayerOn = false;
        }
    }
}
