using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogNPC : MonoBehaviour
{
    [SerializeField] private GameObject _dialogPanel;
    [SerializeField] private TMP_Text _dialogTxt;
    [SerializeField] private string _dialog;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _dialogPanel.SetActive(true);
        _dialogTxt.text = _dialog;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _dialogPanel.SetActive(false);
    }
}
