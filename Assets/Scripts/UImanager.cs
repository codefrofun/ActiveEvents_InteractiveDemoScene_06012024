using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Actionsmanager;
using UnityEditor.PackageManager.Requests;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI winText;

    public void Start()
    {
        winText.text = " "; // Making sure the the text is not visible at the start
    }

    void OnEnable()
    {
        // Subscribe to the basket scored event
        ActionsManager.OnBasketScoredEvent += ShowWinText;
    }

    void OnDisable()
    {
        // Unsubscribe from the event
        ActionsManager.OnBasketScoredEvent -= ShowWinText;
    }

    private void ShowWinText()
    {
        winText.text = "You Win!"; // Printing Text
        StartCoroutine("DisableText"); // Calling teh coroutine
    }

    IEnumerator DisableText()
    {
        yield return new WaitForSeconds(5); // Adding seconds until text disappears
        winText.text = " "; // Removing visible text
    }
}
