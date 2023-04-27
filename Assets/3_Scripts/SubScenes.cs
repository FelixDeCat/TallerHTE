using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SubScenes : MonoBehaviour
{
    public int scenesCount;
    [SerializeField] string[] extras;
    HashSet<AsyncOperation> operations;

    private void Start()
    {
        StartCoroutine(LoadScenes());
    }

    IEnumerator LoadScenes()
    {
        string levelName = SceneManager.GetActiveScene().name;

        for (int i = 0; i < scenesCount; i++)
        {
            yield return SceneManager.LoadSceneAsync(levelName + "_" + i, LoadSceneMode.Additive);
            yield return new WaitForSeconds(0.2f);
        }

        for (int i = 0; i < extras.Length; i++)
        {
            yield return SceneManager.LoadSceneAsync(levelName + "_" + extras[i], LoadSceneMode.Additive);
            yield return new WaitForSeconds(0.2f);
        }
    }
}
