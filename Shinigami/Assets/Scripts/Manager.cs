using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    bool gameEnded = false;
    bool winGame = false;
    public GameObject gameOverUI;
    public GameObject gameWinUI;
    private void Start()
    {
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);
    }
    public void EndGame()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            //Debug.Log("Game over");
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void WinGame()
    {
        if (!winGame)
        {
            gameEnded = true;
            winGame = true;
            //Debug.Log("Game over");
            gameOverUI.SetActive(false);
            gameWinUI.SetActive(true);
            
            Time.timeScale = 0f;
        }
    }
}
