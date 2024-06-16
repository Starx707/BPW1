using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollect : MonoBehaviour
{
    [SerializeField] CoinManager _Cm;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            _Cm._coinCount ++;
        }
    }
}
