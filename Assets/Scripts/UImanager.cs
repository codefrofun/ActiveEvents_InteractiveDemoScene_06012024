using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Actionsmanager;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI winText;


    void OnEnable()
    {
        // Subscribe to the basket scored event
        ActionsManager.OnBasketScoredEvent += ShowWinText;
    }

    void OnDisable()
    {
        // Unsubscribe from the event to avoid memory issues
        ActionsManager.OnBasketScoredEvent -= ShowWinText;
    }

    private void ShowWinText()
    {
        winText.text = "You Win!";
        Invoke("You Win!", 6.0f);
    }
}
