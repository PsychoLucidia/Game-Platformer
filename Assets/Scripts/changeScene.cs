using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public GameObject objLoadScreen;

    public void goToSceneAsync(int sceneid)
    {
        StartCoroutine(sceneAsync(sceneid));
    }

    IEnumerator sceneAsync(int sceneid)
    {
        AsyncOperation sceneLoad = SceneManager.LoadSceneAsync(sceneid);

        objLoadScreen.SetActive(true);

        while (!sceneLoad.isDone)
        {
            yield return null;
        }
    }
}
