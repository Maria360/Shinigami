using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    bool gameEnded = false;
    public GameObject gameOverUI;
    private void Start()
    {
        gameOverUI.SetActive(false);
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
}
