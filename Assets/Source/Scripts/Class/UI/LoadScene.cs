using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public GameObject canvasObject;
    public Slider progressBar;
    private Canvas canvas;

    public int sahneNo = 0;

    private void Start()
    {
        canvasObject.SetActive(false);
    }
    public void Load(int level)
    {
        canvasObject.SetActive(true);

        StartCoroutine(StartLoading(sahneNo));
    }

    IEnumerator StartLoading(int level)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(level);

        while (!async.isDone)
        {
            progressBar.value = async.progress;
            yield return null;
        }
    }
}
