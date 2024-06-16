using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPotion : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameManager _gm;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<playerMovement>())
        {
            if(_player.Health < 3)
            {
                _player.Health++;
                _gm.playerHPTracker++;
                _gm.PlayerHeal();
            }
            else
            {
                Debug.Log("Full hp");
            }
            Destroy(gameObject);
        }
    }
}