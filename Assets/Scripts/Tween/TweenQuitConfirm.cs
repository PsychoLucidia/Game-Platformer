using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenQuitConfirm : MonoBehaviour
{
    public CanvasGroup quitTextAl, quitButtonsAl, quitBGAlpha;
    public Transform uiLine, quitText, quitButtons;
    public GameObject canvasToggle;
    public Image background;

    public void popUpConfirm()
    {
        uiLine.localScale = new Vector3(1, 1, 1);
        uiLine.LeanScale(new Vector3(0, 1, 1), 1).setEaseInCubic();

        quitText.LeanMoveLocal(new Vector2(-281, 31), 1).setEaseInCubic();
        quitTextAl.alpha = 1;
        quitTextAl.LeanAlpha(0, 1);

        quitButtons.localPosition = new Vector2(0, 0);
        quitButtons.LeanMoveLocal(new Vector2(20, 0), 1).setEaseInCubic();
        quitButtonsAl.alpha = 1;
        quitButtonsAl.LeanAlpha(0, 1);

        quitBGAlpha.alpha = 0.5f;
        quitBGAlpha.LeanAlpha(1, 1);

        StartCoroutine(cancelDelay());
    }

    IEnumerator cancelDelay()
    {
        yield return new WaitForSeconds(1);
        Application.Quit();

        Debug.Log("App successfully quited.");
    }
}
