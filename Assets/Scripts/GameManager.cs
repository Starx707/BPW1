using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Player data

    //Enemy data
    public int enemiesDefeated;

    //UI data
    [SerializeField] private GameObject _GameUI;
    [SerializeField] private GameObject _pausePanel;
    bool _gamePaused = false;

    [SerializeField] private TMP_Text _enemiesDefeated;
    public int enemyDeathCount;

    //Game data (such as score)


    // Start is called before the first frame update
    void Start()
    {
        
    }

    //------Fighting
    //Enemy defeated ()


    //------ Game
    //Treasure collected ()


    public void EnemyDefeated()
    {
        _enemiesDefeated.text = enemyDeathCount.ToString();
    }


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
