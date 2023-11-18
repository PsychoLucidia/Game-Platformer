using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    private PauseTween pauseScript;
    [SerializeField] private bool isPaused = false;
    [SerializeField] private bool inOptions = false;
    [SerializeField] private bool inQuit = false;


    void Start()
    {
        pauseScript = GetComponent<PauseTween>();    }
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
                    pauseScript.pauseCloseOptions();
                }
                else if (inQuit)
                {
                    inQuit = false;
                }
            }
            else if (isPaused)
            {
                isPaused = false;
                pauseScript.closePause();
            }
            else if (!isPaused)
            {
                isPaused = true;
                pauseScript.openPause();
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
}
