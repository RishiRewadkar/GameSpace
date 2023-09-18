using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;

    public void GameOver()
    {
        gameOver = true;
        Time.timeScale = 0f;
        // You can add game over logic here, such as displaying a game over screen.
        // You can also trigger any necessary cleanup or restart actions.
    }

    public bool IsGameOver()
    {
        
        return gameOver;
    }

}
