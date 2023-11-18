using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenToOptions : MonoBehaviour
{
    public CanvasGroup menuAlpha, transBGAlpha, optionsBGAlpha, textOpAlpha, opBackAlpha, optionsAdjustablesAlpha;
    public Transform menuText, transBG, optionsBG, optionsAdjustables;
    public GameObject options, menu;
    public void toOptions()
    {
        menuAlpha.alpha = 1;
        transBGAlpha.alpha = 0.7f;
        menuAlpha.LeanAlpha(0, 0.5f);
        transBGAlpha.LeanAlpha(0, 0.5f);
        menuText.LeanMoveLocal(new Vector2(-556, -333), 0.5f).setEaseInCubic();
        transBG.LeanMoveLocal(new Vector2(-1500, 0), 0.5f).setEaseInCubic();

        StartCoroutine(delToOptions());
    }
    
    IEnumerator delToOptions()
    {
        yield return new WaitForSeconds(0.5f);

        options.SetActive(true);
        menu.SetActive(false);

        optionsBG.localPosition = new Vector2(1500, 0);
        optionsAdjustables.localPosition = new Vector2(0, 20);
        textOpAlpha.alpha = 0;
        opBackAlpha.alpha = 0;
        optionsBGAlpha.alpha = 0;
        optionsAdjustablesAlpha.alpha = 0;

        optionsBG.LeanMoveLocal(new Vector2(630, 0), 0.5f).setEaseOutCubic();
        optionsAdjustables.LeanMoveLocal(new Vector2(0, 0), 0.3f).setDelay(0.3f).setEaseOutCubic();
        textOpAlpha.LeanAlpha(1, 0.3f);
        optionsAdjustablesAlpha.LeanAlpha(1, 0.3f).setDelay(0.3f);
        optionsBGAlpha.LeanAlpha(0.7f, 0.5f).setOnComplete(fadeInOp);
    }

    void fadeInOp()
    {
        opBackAlpha.LeanAlpha(1, 0.5f);
    }
}
