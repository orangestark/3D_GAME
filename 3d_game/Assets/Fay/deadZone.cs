using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;

public class deadZone : MonoBehaviour
{
    public GameObject player;
 public TMP_Text gameOverText;
    private void Start()
    {
        gameOverText.gameObject.SetActive(false); 
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("Game Over");
gameOverText.gameObject.SetActive(true);
            StartCoroutine(RestartSceneAfterDelay(2f));
        }
    }

    IEnumerator RestartSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}