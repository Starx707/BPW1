using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    [SerializeField] private GameManager _gm;
    public int coinsGoal = 4;
    public int killGoal = 6;

    [SerializeField] private TMP_Text _dialogNPC; //dialog in the UI
    [SerializeField] private Color _colorDialogNPC; //color depending on which of two is talking

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (_gm.collectedCoins >= coinsGoal && _gm.enemiesDefeated >= killGoal)
            {
                SceneManager.LoadSceneAsync("GameWon");
            }
            else if (_gm.collectedCoins >= coinsGoal && _gm.enemiesDefeated >= killGoal)
            {
                //not enough of both (both NPC)
                Debug.Log("Missing both");
            }
            else if (_gm.collectedCoins <= coinsGoal)
            {
                //not enough gold dialog (NPC 1)
                Debug.Log("Missing coins");
            }
            else if (_gm.enemiesDefeated <= killGoal)
            {
                //nog enough kills (NPC 2)
                Debug.Log("Missing kills");
            }

        }
    }
}


