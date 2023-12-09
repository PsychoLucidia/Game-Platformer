using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    private PauseTween pauseTween;
    [SerializeField] private bool isPaused = false;
    [SerializeField] private bool inOptions = false;
    [SerializeField] private bool inQuit = false;


    void Start()
    {
        pauseTween = GetComponent<PauseTween>();    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == true && (inOptions == true || inQuit == true))
            {
                if (inOptions)
                {
                    inOptions = false;
                    pauseTween.pauseCloseOptions();
                }
                else if (inQuit)
                {
                    inQuit = false;
                    pauseTween.pauseCloseExit();
                }
            }
            else if (isPaused)
            {
                isPaused = false;
                pauseTween.closePause();
            }
            else if (!isPaused)
            {
                isPaused = true;
                pauseTween.openPause();
            }
        }
    }

    public void optionsTrue()
    {
        inOptions = true;
    }

    public void optionsFalse()
    {
        inOptions = false;
    }

    public void quitTrue()
    {
        inQuit = true;
    }

    public void quitFalse()
    {
        inQuit = false;
    }

    public void pauseTrue()
    {
        isPaused = true;
    }

    public void pauseFalse()
    {
        isPaused = false;
    }
}
