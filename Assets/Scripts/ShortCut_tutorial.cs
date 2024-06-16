using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShortCut_tutorial : MonoBehaviour
{
    bool _nearShortCut = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _nearShortCut = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _nearShortCut = false;
        }
    }

    private void UseShortcut()
    {
        if (_nearShortCut)
        {
            SceneManager.LoadSceneAsync("MainLevel"); 
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            UseShortcut();
        }
    }
}
