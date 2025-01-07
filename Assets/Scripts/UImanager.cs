using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public Text winText;

    void OnEnable()
    {
        // Move Basketball and show the win text
    }

    void OnDisable()
    {
        // Don't move Don't show wintext
    }

    private void ShowWinText()
    {
        winText.text = "You Win!";
    }
}
