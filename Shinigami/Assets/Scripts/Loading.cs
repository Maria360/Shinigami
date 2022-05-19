using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Slider slider;
    public GameObject panel;
    public string[] tips;
    public Text tipsTXT;
    private void Start()
    {
        string levelToLoad = LevelLoader.nextLevel;
        StartCoroutine(this.MakeTheLoad(levelToLoad));
    }
    IEnumerator MakeTheLoad(string level)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(level);
        panel.SetActive(true);
        while(!operation.isDone)
        {
            float progreso = Mathf.Clamp01(operation.progress/0.9f);
            slider.value = progreso;
            tipsTXT.text = tips[Random.Range(0, tips.Length)];
            //slider.value = operation.progress;

            yield return null;
        }
    }
}
