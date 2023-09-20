using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float timer = 0f;
    public GameManager gameManager;

    void Update()
    {
        // Check if the game is not over
        if (!gameManager.IsGameOver())
        {
            // Update the timer
            timer += Time.deltaTime;
        }
    }

    void OnGUI()
    {
        // Convert timer to minutes and seconds
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);

        Rect labelRect = new Rect(Screen.width - 120, 10, 100, 40);

        GUIStyle style = new GUIStyle(GUI.skin.label);
        style.fontSize = 16;

        // Display the timer with the updated style and position
        GUI.Label(labelRect, string.Format("Survived: {0:00}:{1:00}", minutes, seconds), style);

    }

    // Rest of your code...
}

