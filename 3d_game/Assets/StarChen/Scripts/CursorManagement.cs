using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowCursor();
    }

    // Update is called once per frame
    void ShowCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    void HideCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
