using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private string scene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Load New Scene");
            ChangeScene();
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(scene);    
    }
}
