using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Player data
    public int playerHPTracker;

    //Enemy data
    public int enemiesDefeated;

    //UI data
    public bool tutorialLvl = true;
    [SerializeField] private GameObject _GameUI;
    [SerializeField] private GameObject _pausePanel;
    bool _gamePaused = false;

    [SerializeField] private Sprite _fullHP;
    [SerializeField] private Sprite _2HP;
    [SerializeField] private Sprite _1HP;
    [SerializeField] private Sprite _0HP;
    [SerializeField] private Image _hpSpriteUI;

    [SerializeField] private TMP_Text _enemiesDefeated;
    public int enemyDeathCount;

    //Game data (such as score)
    public int collectedCoins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //------Fighting
    //Enemy defeated ()


    //------ Game
    //Treasure collected ()

    public void PlayerDamaged()
    {
        Debug.Log(playerHPTracker + " hp left");
        if (playerHPTracker == 2)
        {
            Debug.Log(playerHPTracker + " hp left");
            _hpSpriteUI.overrideSprite = _2HP;
        }
        else if (playerHPTracker == 1)
        {
            _hpSpriteUI.overrideSprite = _1HP;
        }
        else if (playerHPTracker <= 0)
        {
            _hpSpriteUI.overrideSprite = _0HP;
            GameOver();
            Debug.Log("Player defeated");
            //Call Gameover
        }
    }

    public void PlayerHeal()
    {
        Debug.Log("Player heals");
        Debug.Log(playerHPTracker + " is current hp");
        if (playerHPTracker == 1)
        {
            _hpSpriteUI.overrideSprite = _1HP;
        }
        else if (playerHPTracker == 2)
        {
            _hpSpriteUI.overrideSprite = _2HP;
        }
        else if (playerHPTracker == 3)
        {
            _hpSpriteUI.overrideSprite = _fullHP;
        }
    }

    public void EnemyDefeated()
    {
        _enemiesDefeated.text = enemyDeathCount.ToString();
    }

    private void GameOver()
    {
        //Call when player defeated
        SceneManager.LoadSceneAsync("GameOver");
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
