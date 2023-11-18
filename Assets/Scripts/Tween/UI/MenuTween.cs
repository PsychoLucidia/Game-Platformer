using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MenuTween : MonoBehaviour
{
    private changeScene changeScript;

    public CanvasGroup logoAlpha, pressAnywhereAlpha;
    public Transform logoTrans;

    public CanvasGroup vertiGroupAlpha, menuLineAlpha;
    public Transform menuLine, vertiGroupTrans;

    public CanvasGroup optOptTextAlpha, optLineAlpha, optTextAlpha, optSliderAlpha, optBackAlpha;
    public Transform optOptTextTrans, optLineScale, optTextTrans, optSliderTrans, optBackTrans;

    public CanvasGroup quitBackgroundCanGro, quitTextCanGro, quitButtonCanGro;
    public Transform quitLineTrans, quitTextTrans, quitButtonTrans;

    public CanvasGroup blackOverlayCanGro;

    public GameObject objLogo, objTitleButton, objTitle, objMenu, objOptions, objQuit, objBlackOverlay;

    void Start()
    {
        changeScript = GetComponent<changeScene>();

        objLogo.SetActive(true);
        objTitle.SetActive(true);
        objTitleButton.SetActive(false);
        objMenu.SetActive(false);
        objOptions.SetActive(false);
        objQuit.SetActive(false);
        objBlackOverlay.SetActive(false);


        StartCoroutine(titleIntroAnim());
    }
    // Call functions
    public void titletoMenu()
    {
        titToMen();
    }

    public void menuToTitle()
    {
        menToTit();
    }

    public void startGame()
    {
        startGm();
    }

    public void menuToOptions()
    {
        menToOpt();
    }

    public void optionsToMenu()
    {
        opToMen();
    }

    public void quitPopUp()
    {
        quitPoUp();
    }

    public void quitPopOut()
    {
        quitPoOut();
    }

    // Functions that makes the animation works
    void titToMen()
    {
        StartCoroutine(titToMenAnim());

        IEnumerator titToMenAnim()
        {
            vertiGroupAlpha.interactable = true;

            pressAnywhereAlpha.alpha = 1;
            logoTrans.localPosition = new Vector2(0, 150);

            vertiGroupAlpha.alpha = 0;
            menuLineAlpha.alpha = 0;
            vertiGroupTrans.localPosition = new Vector2(0, -278);
            menuLine.localScale = new Vector3(0, 1, 1);

            pressAnywhereAlpha.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            logoTrans.LeanMoveLocal(new Vector2(0, 190), 1f).setEaseInOutCubic().setIgnoreTimeScale(true);

            objTitleButton.SetActive(false);

            yield return new WaitForSecondsRealtime(0.8f);
            objMenu.SetActive(true);
            objTitle.SetActive(false);

            vertiGroupAlpha.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            menuLineAlpha.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            vertiGroupTrans.LeanMoveLocal(new Vector2(0, -288), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            menuLine.LeanScale(new Vector3(1, 1, 1), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
        }
    }

    void menToTit()
    {
        StartCoroutine(mentoTitAnim());

        IEnumerator mentoTitAnim()
        {
            vertiGroupAlpha.interactable = false;

            pressAnywhereAlpha.alpha = 0;
            logoTrans.localPosition = new Vector2(0, 190);

            vertiGroupAlpha.alpha = 1;
            menuLineAlpha.alpha = 1;
            vertiGroupTrans.localPosition = new Vector2(0, -288);
            menuLine.localScale = new Vector3(1, 1, 1);

            logoTrans.LeanMoveLocal(new Vector2(0, 150), 1f).setEaseInOutCubic().setIgnoreTimeScale(true);

            vertiGroupAlpha.LeanAlpha(0, 0.4f).setEaseInCubic().setIgnoreTimeScale(true);
            menuLineAlpha.LeanAlpha(0, 0.4f).setEaseInCubic().setIgnoreTimeScale(true);
            vertiGroupTrans.LeanMoveLocal(new Vector2(0, -278), 0.4f).setEaseInCubic().setIgnoreTimeScale(true);
            menuLine.LeanScale(new Vector3(0, 1, 1), 0.4f).setEaseInCubic().setIgnoreTimeScale(true);


            yield return new WaitForSecondsRealtime(0.8f);
            objMenu.SetActive(false);
            objTitle.SetActive(true);
            objTitleButton.SetActive(true);

            pressAnywhereAlpha.LeanAlpha(1, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
        }
    }

    void startGm()
    {
        StartCoroutine(startGmAnim());

        IEnumerator startGmAnim()
        {
            objBlackOverlay.SetActive(true);
            vertiGroupAlpha.interactable = false;

            vertiGroupAlpha.alpha = 1;
            menuLineAlpha.alpha = 1;
            logoAlpha.alpha = 1;
            vertiGroupTrans.localPosition = new Vector2(0, -288);
            logoTrans.localPosition = new Vector2(0, 190);
            menuLine.localScale = new Vector3(1, 1, 1);

            blackOverlayCanGro.alpha = 0;

            vertiGroupAlpha.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            menuLineAlpha.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            logoAlpha.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            vertiGroupTrans.LeanMoveLocal(new Vector2(0, -278), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            logoTrans.LeanMoveLocal(new Vector2(0, 180), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            menuLine.LeanScale(new Vector3(0, 1, 1), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);

            blackOverlayCanGro.LeanAlpha(1, 2f).setEaseInCubic().setIgnoreTimeScale(true);

            yield return new WaitForSecondsRealtime(2.5f);
            changeScript.goToSceneAsync(2);
        }
    }

    void menToOpt()
    {
        StartCoroutine(menToOptAnim());

        IEnumerator menToOptAnim()
        {
            vertiGroupAlpha.interactable = false;
            optBackAlpha.interactable = true;

            vertiGroupAlpha.alpha = 1;
            menuLineAlpha.alpha = 1;
            logoAlpha.alpha = 1;
            vertiGroupTrans.localPosition = new Vector2(0, -288);
            logoTrans.localPosition = new Vector2(0, 190);
            menuLine.localScale = new Vector3(1, 1, 1);

            optOptTextAlpha.alpha = 0;
            optLineAlpha.alpha = 0;
            optTextAlpha.alpha = 0;
            optSliderAlpha.alpha = 0;
            optBackAlpha.alpha = 0;
            optTextTrans.localPosition = new Vector2(10, 0);
            optSliderTrans.localPosition = new Vector2(-10, 0);
            optBackTrans.localPosition = new Vector2(0, -405);
            optLineScale.localScale = new Vector3(1, 0, 1);

            vertiGroupAlpha.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            menuLineAlpha.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            logoAlpha.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            vertiGroupTrans.LeanMoveLocal(new Vector2(0, -278), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            logoTrans.LeanMoveLocal(new Vector2(0, 180), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            menuLine.LeanScale(new Vector3(0, 1, 1), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);

            yield return new WaitForSecondsRealtime(0.6f);
            objLogo.SetActive(false);
            objMenu.SetActive(false);
            objOptions.SetActive(true);

            optOptTextAlpha.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            optLineAlpha.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            optTextAlpha.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            optSliderAlpha.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            optBackAlpha.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            optTextTrans.LeanMoveLocal(new Vector2(0, 0), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            optSliderTrans.LeanMoveLocal(new Vector2(0, 0), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            optBackTrans.LeanMoveLocal(new Vector2(0, -415), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            optLineScale.LeanScale(new Vector3(1, 1, 1), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);

        }
    }

    void opToMen()
    {
        StartCoroutine(opToMenAnim());

        IEnumerator opToMenAnim()
        {
            vertiGroupAlpha.interactable = true;
            optBackAlpha.interactable = false;

            vertiGroupAlpha.alpha = 0;
            menuLineAlpha.alpha = 0;
            logoAlpha.alpha = 0;
            vertiGroupTrans.localPosition = new Vector2(0, -278);
            logoTrans.localPosition = new Vector2(0, 180);
            menuLine.localScale = new Vector3(0, 1, 1);

            optOptTextAlpha.alpha = 1;
            optLineAlpha.alpha = 1;
            optTextAlpha.alpha = 1;
            optSliderAlpha.alpha = 1;
            optBackAlpha.alpha = 1;
            optTextTrans.localPosition = new Vector2(0, 0);
            optSliderTrans.localPosition = new Vector2(0, 0);
            optBackTrans.localPosition = new Vector2(0, -415);
            optLineScale.localScale = new Vector3(1, 1, 1);


            optOptTextAlpha.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            optLineAlpha.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            optTextAlpha.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            optSliderAlpha.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            optBackAlpha.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            optTextTrans.LeanMoveLocal(new Vector2(10, 0), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            optSliderTrans.LeanMoveLocal(new Vector2(-10, 0), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            optBackTrans.LeanMoveLocal(new Vector2(0, -405), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            optLineScale.LeanScale(new Vector3(1, 0, 1), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);


            yield return new WaitForSecondsRealtime(0.6f);
            objLogo.SetActive(true);
            objMenu.SetActive(true);
            objOptions.SetActive(false);

            vertiGroupAlpha.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            menuLineAlpha.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            logoAlpha.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            vertiGroupTrans.LeanMoveLocal(new Vector2(0, -288), 0.3f).setEaseOutCubic().setIgnoreTimeScale(true);
            logoTrans.LeanMoveLocal(new Vector2(0, 190), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            menuLine.LeanScale(new Vector3(1, 1, 1), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
        }
    }

    void quitPoUp()
    {
        StartCoroutine(quitPoUpAnim());

        IEnumerator quitPoUpAnim()
        {
            objQuit.SetActive(true);
            quitTextCanGro.interactable = true;

            quitBackgroundCanGro.alpha = 0;
            quitTextCanGro.alpha = 0;
            quitButtonCanGro.alpha = 0;
            quitTextTrans.localPosition = new Vector2(-20, 35);
            quitButtonTrans.localPosition = new Vector2(20, 0);
            quitLineTrans.localScale = new Vector3(0, 1, 1);

            quitBackgroundCanGro.LeanAlpha(1, 0.2f);
            quitLineTrans.LeanScale(new Vector3(1, 1, 1), 0.5f).setEaseOutCubic().setIgnoreTimeScale(true);

            yield return new WaitForSecondsRealtime(0.3f);
            quitTextCanGro.LeanAlpha(1, 0.2f).setEaseOutCubic().setIgnoreTimeScale(true);
            quitButtonCanGro.LeanAlpha(1, 0.2f).setEaseOutCubic().setIgnoreTimeScale(true);
            quitTextTrans.LeanMoveLocal(new Vector2(0, 35), 0.2f).setEaseOutCubic().setIgnoreTimeScale(true);
            quitButtonTrans.LeanMoveLocal(new Vector2(0, 0), 0.2f).setEaseOutCubic().setIgnoreTimeScale(true);
        }
    }

    void quitPoOut()
    {
        StartCoroutine(quitPoOutAnim());

        IEnumerator quitPoOutAnim()
        {
            quitTextCanGro.interactable = false;

            quitBackgroundCanGro.alpha = 1;
            quitTextCanGro.alpha = 1;
            quitButtonCanGro.alpha = 1;
            quitTextTrans.localPosition = new Vector2(0, 35);
            quitButtonTrans.localPosition = new Vector2(0, 0);
            quitLineTrans.localScale = new Vector3(1, 1, 1);

            quitTextCanGro.LeanAlpha(0, 0.2f).setEaseInCubic().setIgnoreTimeScale(true);
            quitButtonCanGro.LeanAlpha(0, 0.2f).setEaseInCubic().setIgnoreTimeScale(true);
            quitTextTrans.LeanMoveLocal(new Vector2(20, 35), 0.2f).setEaseInCubic().setIgnoreTimeScale(true);
            quitButtonTrans.LeanMoveLocal(new Vector2(-20, 0), 0.2f).setEaseInCubic().setIgnoreTimeScale(true);
            quitLineTrans.LeanScale(new Vector3(0, 1, 1), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);

            yield return new WaitForSecondsRealtime(0.2f);
            quitBackgroundCanGro.LeanAlpha(0, 0.1f);

            yield return new WaitForSecondsRealtime(0.1f);
            objQuit.SetActive(false);
        }
    }

    IEnumerator titleIntroAnim()
    {
        objBlackOverlay.SetActive(true);

        pressAnywhereAlpha.alpha = 0;
        logoAlpha.alpha = 0;
        logoTrans.localPosition = new Vector2(0, 150);
        logoTrans.localScale = new Vector3(1.2f, 1.2f, 1);
        blackOverlayCanGro.alpha = 1;

        blackOverlayCanGro.LeanAlpha(0, 1);
        yield return new WaitForSecondsRealtime(1f);
        objBlackOverlay.SetActive(false);

        yield return new WaitForSecondsRealtime(3f);
        logoAlpha.LeanAlpha(1, 1).setEaseOutCubic().setIgnoreTimeScale(true);
        logoTrans.LeanScale(new Vector3(1, 1, 1), 1).setEaseOutCubic().setIgnoreTimeScale(true);

        yield return new WaitForSecondsRealtime(1f);
        objTitleButton.SetActive(true);

        pressAnywhereAlpha.LeanAlpha(1, 1).setEaseInOutCubic().setIgnoreTimeScale(true);
    }
}
