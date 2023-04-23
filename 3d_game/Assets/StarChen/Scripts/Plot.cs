using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Plot : MonoBehaviour
{
    private int _sentence = 0;

    [SerializeField] private TMP_Text text;

    [SerializeField] private GameObject canvas;

    [SerializeField] private PlayerInput input;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip clip00;
    [SerializeField] private AudioClip clip0;
    [SerializeField] private AudioClip clip1;
    [SerializeField] private AudioClip clip2;
    [SerializeField] private AudioClip clip3;
    [SerializeField] private AudioClip clip4;
    [SerializeField] private AudioClip clip5;
    [SerializeField] private AudioClip clip6;
    
    // Start is called before the first frame update
    void Start()
    {
        input.enabled = false;
        audioSource.PlayOneShot(clip00);
    }

    // Update is called once per frame
    void Update()
    {
        switch (_sentence)
        {
            case (0) :
                if (Input.GetMouseButtonDown(0))
                {
                    text.text = "Here you will experience the ultimate journey of gravity.";
                    audioSource.Stop();
                    audioSource.PlayOneShot(clip0);
                    ++_sentence;
                }
                break;
            case (1) :
                if (Input.GetMouseButtonDown(0))
                {
                    text.text = "Two planets are colliding, and you need to get the hell out of here!!!";
                    audioSource.Stop();
                    audioSource.PlayOneShot(clip1);
                    ++_sentence;
                }
                break;
            case (2) :
                if (Input.GetMouseButtonDown(0))
                {
                    text.text = "However, because of gravity, everything around you will act oddly. ";
                    audioSource.Stop();
                    audioSource.PlayOneShot(clip2);
                    ++_sentence;
                }
                break;
            case (3) :
                if (Input.GetMouseButtonDown(0))
                {
                    text.text = "Forget the law of gravity in your world.";
                    audioSource.Stop();
                    audioSource.PlayOneShot(clip3);
                    ++_sentence;
                }
                break;
            case (4) :
                if (Input.GetMouseButtonDown(0))
                {
                    text.text = "Use your imagination to discover your surroundings...";
                    audioSource.Stop();
                    audioSource.PlayOneShot(clip4);
                    ++_sentence;
                }
                break;
            case (5) :
                if (Input.GetMouseButtonDown(0))
                {
                    text.text = "And witness this great moment of birth of a new world!";
                    audioSource.Stop();
                    audioSource.PlayOneShot(clip5);
                    ++_sentence;
                }
                break;
            case (6) :
                if (Input.GetMouseButtonDown(0))
                {
                    text.alignment = TextAlignmentOptions.Center;
                    text.text = "Good Luck!";
                    audioSource.Stop();
                    audioSource.PlayOneShot(clip6);
                    ++_sentence;
                }
                break;
            case (7) :
                if (Input.GetMouseButtonDown(0))
                {
                    canvas.SetActive(false); 
                    input.enabled = true;
                    ++_sentence;
                }
                break;
            default:
                break;
        }
    }
}
