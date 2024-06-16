using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public int _coinCount;
    [SerializeField] private TextMeshProUGUI _coinCountTxt; 

    private void Update()
    {
        if (_coinCountTxt)
        {
            _coinCountTxt.text = _coinCount.ToString();
        }
    }
}
