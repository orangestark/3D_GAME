using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseCamera : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    void Awake()
    {
        _camera = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ReverseCameraFunction();
        }
    }

    void ReverseCameraFunction()
    {
        Matrix4x4 mat = _camera.projectionMatrix;
        mat *= Matrix4x4.Scale(new Vector3(-1, -1, 1));
        _camera.projectionMatrix = mat;
    }
}
