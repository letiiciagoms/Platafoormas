using System;
using TMPro;
using UnityEngine;

public class MoedasTextController : MonoBehaviour
{
    public TMP_Text moedasText;

    private void OnValidate()
    {
        if (moedasText == null)
        {
            moedasText = GetComponent<TMP_Text>();
        }
    }

    private void OnEnable()
    {
        PlayerObserverManager.OnMoedasChanged += AtualizaMoedas;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnMoedasChanged -= AtualizaMoedas;
    }

    private void AtualizaMoedas(int coins)
    {
        
        moedasText.text = "Moedas: " + coins.ToString();
    }
}
