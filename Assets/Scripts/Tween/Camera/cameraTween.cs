using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTween : MonoBehaviour
{
    Transform leanCamera;

    private void Start()
    {
        leanCamera = GetComponent<Transform>();

        leanCamera.position = new Vector3(0, 200, -10);
        LeanTween.moveY(leanCamera.gameObject, 0, 6f).setEaseInOutCubic().setIgnoreTimeScale(true);
    }

    public void tweenTitleToMenu()
    {
        frTitleToMenu();
    }

    public void tweenMenuToTitle()
    {
        frMenuToTitle();
    }

    public void tweenToOptions()
    {
        goToOptions();
    }

    public void tweenToMenu()
    {
        goToMenu();
    }

    public void tweenToGame()
    {
        goToGame();
    }

    // Tween the Cameras
    void frTitleToMenu()
    {
        leanCamera.position = new Vector3(0, 0, -10);
        LeanTween.moveY(leanCamera.gameObject, 5, 1.5f).setEaseInOutCubic().setIgnoreTimeScale(true);
    }

    void frMenuToTitle()
    {
        leanCamera.position = new Vector3(0, 5, -10);
        LeanTween.moveY(leanCamera.gameObject, 0, 1.5f).setEaseInOutCubic().setIgnoreTimeScale(true);
    }
    void goToOptions()
    {
        leanCamera.position = new Vector3(0, 5, -10);
        LeanTween.moveY(leanCamera.gameObject, -26, 1f).setEaseInOutCubic().setIgnoreTimeScale(true);
    }

    void goToMenu()
    {
        leanCamera.position = new Vector3(0, -26, -10);
        LeanTween.moveY(leanCamera.gameObject, 5, 1f).setEaseInOutCubic().setIgnoreTimeScale(true);
    }

    void goToGame()
    {
        leanCamera.position = new Vector3(0, 5, -10);
        LeanTween.moveY(leanCamera.gameObject, 50, 2f).setEaseInCubic().setIgnoreTimeScale(true);
    }
}
