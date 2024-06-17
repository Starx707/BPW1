using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //------ Main menu
    //Start game ()
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("TutorialScene"); 
    }

    //------ Pause game
    //--later

    //------ Game over screen
    public void RetryGame()
    {
        SceneManager.LoadSceneAsync("MainLevel");
    }


    //------ General
    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    //------ Sfx
    /*
    > pause
    > menu
    > game over
     */
}
