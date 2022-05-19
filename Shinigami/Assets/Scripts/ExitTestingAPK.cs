using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTestingAPK : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("EXIT");
    }
    public void StartGame()
    {
        LevelLoader.LoadLevel("Nivel");
        //SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
    public void StartTuto()
    {
        LevelLoader.LoadLevel("Tutorial");
        //SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}
