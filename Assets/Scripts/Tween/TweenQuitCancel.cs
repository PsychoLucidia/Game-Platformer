using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenQuitCancel : MonoBehaviour
{
    public CanvasGroup quitTextAl, quitButtonsAl, quitBGAlpha;
    public Transform uiLine, quitText, quitButtons;
    public GameObject canvasToggle;

    public void popUpCancel()
    {
        uiLine.localScale = new Vector3(1, 1, 1);
        uiLine.LeanScale(new Vector3(0, 1, 1), 0.3f).setEaseInCubic();

        quitText.LeanMoveLocal(new Vector2(-281, 31), 0.3f).setEaseInCubic();
        quitTextAl.alpha = 1;
        quitTextAl.LeanAlpha(0, 0.3f);

        quitButtons.localPosition = new Vector2(0, 0);
        quitButtons.LeanMoveLocal(new Vector2(20, 0), 0.3f).setEaseInCubic();
        quitButtonsAl.alpha = 1;
        quitButtonsAl.LeanAlpha(0, 0.3f);

        quitBGAlpha.alpha = 0.5f;
        quitBGAlpha.LeanAlpha(0, 0.1f).setDelay(0.2f);

        StartCoroutine(cancelDelay());
    }

    IEnumerator cancelDelay()
    {
        yield return new WaitForSeconds(0.3f);
        canvasToggle.SetActive(false);

    }
}
