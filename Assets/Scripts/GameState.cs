using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    [SerializeField] private GameManager _gm;
    public int coinsGoal = 3; //Change before build
    public int killGoal = 3; //Change before build

    [SerializeField] private TMP_Text _dialogNPC; //dialog in the UI
    [SerializeField] private Color _colorDialogNPC; //color depending on which of two is talking
    [SerializeField] private GameObject _dialogObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (_gm.collectedCoins >= coinsGoal && _gm.enemyDeathCount >= killGoal)
            {
                SceneManager.LoadSceneAsync("GameWon");
            }
            else if (_gm.collectedCoins < coinsGoal && _gm.enemyDeathCount < killGoal)
            {
                //not enough of both (both NPC) "We want to see this and this"
                _dialogObject.SetActive(true);
                _dialogNPC.text = "We'd like to see a few more coins and enemies killed";
                Debug.Log("Missing both");
            }
            else if (_gm.collectedCoins < coinsGoal)
            {
                //not enough gold dialog (NPC 1) "I still want to see this many coins, this many left to get"
                _dialogObject.SetActive(true);
                _dialogNPC.text = "I'd like to see a few more coins collected!";
                Debug.Log("Missing coins");
            }
            else if (_gm.enemyDeathCount < killGoal)
            {
                //nog enough kills (NPC 2) "I still want to see this many kills, this many left to get"
                _dialogObject.SetActive(true);
                _dialogNPC.text = "Could you defeat a few more enemies for me?";
                Debug.Log(_gm.enemyDeathCount);
            }
            else
            {
                Debug.Log("Requirements met!");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _dialogObject.SetActive(false);
        Debug.Log("Deactivate dialog");
    }
}


