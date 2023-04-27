using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubScenes : MonoBehaviour
{
    string baseName = "";
    public int scenes = 3;
    public string[] extras;

    private void Start()
    {
        baseName = SceneManager.GetActiveScene().name;

        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        for (int i = 0; i < scenes; i++)
        {
            yield return SceneManager.LoadSceneAsync(baseName + "_" + i, LoadSceneMode.Additive);
        }

        for (int i = 0; i < extras.Length; i++)
        {
            yield return SceneManager.LoadSceneAsync(baseName + "_" + extras[i], LoadSceneMode.Additive);
        }
    }
}
