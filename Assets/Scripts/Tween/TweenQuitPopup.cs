using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenQuitPopup : MonoBehaviour
{
    public GameObject quitObj;
    public CanvasGroup quitBG, quitTextAlpha, quitButtonsAlpha, canvasAlpha;
    public Transform quitLine, quitText, quitButtons;

    public void PopUp()
    {
        quitObj.SetActive(true);
        canvasAlpha.alpha = 1;
        quitBG.alpha = 0;
        quitBG.LeanAlpha(0.5f, 0.3f);
        quitLine.localScale = new Vector3(0, 1, 1);
        quitLine.LeanScale(new Vector3(1, 1, 1), 0.5f).setEaseOutCubic();
        quitText.localPosition = new Vector2(-241, 31);
        quitText.LeanMoveLocal(new Vector2(-261, 31), 0.3f).setDelay(0.3f).setEaseOutCubic();
        quitTextAlpha.alpha = 0;
        quitTextAlpha.LeanAlpha(1, 0.3f).setDelay(0.3f);
        quitButtons.localPosition = new Vector2(-20, 0);
        quitButtons.LeanMoveLocal(new Vector2(0, 0), 0.3f).setDelay(0.3f).setEaseOutCubic();
        quitButtonsAlpha.alpha = 0;
        quitButtonsAlpha.LeanAlpha(1, 0.4f).setDelay(0.3f);
    }
}
