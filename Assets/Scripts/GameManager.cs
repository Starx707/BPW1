using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //Player data

    //Enemy data

    //UI data
    [SerializeField] private GameObject _GameUI;
    [SerializeField] private GameObject _pausePanel;
    bool _gamePaused = false;

    //Game data (such as score)


    // Start is called before the first frame update
    void Start()
    {
        
    }

    //------Fighting
    //Enemy defeated ()


    //------ Game
    //Treasure collected ()


    //Enemies defeated ()


    //------ UI
    private void PauseGame()
    {
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
        //Bullet function still works!
        //UI doesn't respond yet
    }

    public void ContinueGame()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
        _gamePaused = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (_gamePaused == false && Input.GetKeyDown(KeyCode.P))
        {
            _gamePaused = true;
            PauseGame();
        }
    }


}
