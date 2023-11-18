using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartupTween : MonoBehaviour
{
    private changeScene changeScript;
    public CanvasGroup startupTextCanGro;
    public GameObject loadingScreen;
    public TextMeshProUGUI startupText;
    // Start is called before the first frame update
    void Start()
    {
        changeScript = GetComponent<changeScene>();
        loadingScreen.SetActive(false);
        StartCoroutine(startupFunctions());
    }

    IEnumerator startupFunctions()
    {
        startupTextCanGro.alpha = 0;

        startupText.text = "This project is made for Academic Purposes";
        startupTextCanGro.LeanAlpha(1, 0.5f).setIgnoreTimeScale(true);

        yield return new WaitForSecondsRealtime(3.5f);
        startupTextCanGro.LeanAlpha(0, 0.5f).setIgnoreTimeScale(true);

        yield return new WaitForSecondsRealtime(0.5f);
        startupText.text = "Contents are subject to change over time";
        startupTextCanGro.LeanAlpha(1, 0.5f).setIgnoreTimeScale(true);

        yield return new WaitForSecondsRealtime(3.5f);
        startupTextCanGro.LeanAlpha(0, 0.5f).setIgnoreTimeScale(true);

        yield return new WaitForSecondsRealtime(2);
        changeScript.goToSceneAsync(1);
    }
}
