using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenToMenu : MonoBehaviour
{
    public CanvasGroup menuAlpha, transBGAlpha, optionsBGAlpha, textOpAlpha, opBackAlpha, optionsAdjustablesAlpha;
    public Transform menuText, transBG, optionsBG, optionsAdjustables;
    public GameObject options, menu;

    public void toMenu()
    {
        opBackAlpha.alpha = 1;
        opBackAlpha.LeanAlpha(0, 0.5f);

        textOpAlpha.alpha = 1;
        textOpAlpha.LeanAlpha(0, 0.5f);

        optionsBGAlpha.alpha = 0.7f;
        optionsBGAlpha.LeanAlpha(0, 0.5f);

        optionsBG.LeanMoveLocal(new Vector2(1500, 0), 0.5f).setEaseInCubic();

        optionsAdjustablesAlpha.alpha = 1;
        optionsAdjustablesAlpha.LeanAlpha(0, 0.5f);
        optionsAdjustables.localPosition = new Vector2(0, 0);
        optionsAdjustables.LeanMoveLocal(new Vector2(0, -20), 0.5f).setEaseInCubic();

        StartCoroutine(delToMenu());
    }

    IEnumerator delToMenu()
    {
        yield return new WaitForSeconds(0.5f);

        menu.SetActive(true);
        options.SetActive(false);

        menuAlpha.alpha = 0;
        transBGAlpha.alpha = 0;
        menuText.localPosition = new Vector2(-556, -333);
        transBG.localPosition = new Vector2(-1500, 0);

        menuText.LeanMoveLocal(new Vector2(-516, -333), 0.5f).setEaseOutCubic();
        transBG.LeanMoveLocal(new Vector2(-747, 0), 0.5f).setEaseOutCubic();
        menuAlpha.LeanAlpha(1, 0.5f);
        transBGAlpha.LeanAlpha(0.7f, 0.5f);
    }
}
