using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTween : MonoBehaviour
{
    private PauseDisableScript pauseDisableMove;
    private ControlManager controlManager;

    [Header("Pause Menu")]
    public CanvasGroup pauseBackCG;
    public CanvasGroup pauseTextCG;
    public CanvasGroup pauseSelectionCG;
    public Transform pauseLineTrans;
    public Transform pauseTextTrans;
    public Transform pauseSelectionTrans;

    [Header("Pause Options")]
    public CanvasGroup pauOpTextCG;
    public CanvasGroup pauOpSetTextCG;
    public CanvasGroup pauOpSliderCG;
    public CanvasGroup pauOpBackCG;
    public Transform pauOpSetTextTrans;
    public Transform pauOpSliderTrans;
    public Transform pauOpBackTrans;

    [Header("Pause Menu Objects")]
    public GameObject objPause;
    public GameObject objPauseOptions;

    void Start()
    {
        pauseDisableMove = GetComponent<PauseDisableScript>();
        controlManager = GetComponent<ControlManager>();

        objPause.SetActive(false);
        objPauseOptions.SetActive(false);
    }

    public void openPause()
    {
        pauseOpen();
    }

    public void closePause()
    {
        pauseClose();
    }

    public void pauseOpenOptions()
    {
        goToOp();
    }

    public void pauseCloseOptions()
    {
        closeOp();
    }

    void pauseOpen()
    {
        StartCoroutine(pauseOpenAnim());

        IEnumerator pauseOpenAnim()
        {
            Time.timeScale = 0f;
            objPause.SetActive(true);
            pauseDisableMove.disableMovement();

            pauseBackCG.alpha = 0;
            pauseTextCG.alpha = 0;
            pauseSelectionCG.alpha = 0;
            pauseTextTrans.localPosition = new Vector2(0, 95);
            pauseSelectionTrans.localPosition = new Vector2(0, -45);
            pauseLineTrans.localScale = new Vector3(0, 1, 1);

            pauseBackCG.LeanAlpha(1, 0.3f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauseTextCG.LeanAlpha(1, 0.3f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauseSelectionCG.LeanAlpha(1, 0.3f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauseTextTrans.LeanMoveLocal(new Vector2(0, 105), 0.3f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauseSelectionTrans.LeanMoveLocal(new Vector2(0, -55), 0.3f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauseLineTrans.LeanScale(new Vector3(1, 1, 1), 0.3f).setEaseOutCubic().setIgnoreTimeScale(true);

            yield return null;
        }

    }

    void pauseClose()
    {
        StartCoroutine(pauseCloseAnim());

        IEnumerator pauseCloseAnim()
        {
            pauseBackCG.alpha = 1;
            pauseTextCG.alpha = 1;
            pauseSelectionCG.alpha = 1;
            pauseTextTrans.localPosition = new Vector2(0, 105);
            pauseSelectionTrans.localPosition = new Vector2(0, -55);
            pauseLineTrans.localScale = new Vector3(1, 1, 1);

            pauseBackCG.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauseTextCG.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauseSelectionCG.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauseTextTrans.LeanMoveLocal(new Vector2(0, 95), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauseSelectionTrans.LeanMoveLocal(new Vector2(0, -45), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauseLineTrans.LeanScale(new Vector3(0, 1, 1), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);

            yield return new WaitForSecondsRealtime(0.3f);
            Time.timeScale = 1f;
            objPause.SetActive(false);
            pauseDisableMove.enableMovement();
        }
    }

    void goToOp()
    {
        StartCoroutine(goToOpAnim());

        IEnumerator goToOpAnim()
        {
            controlManager.optionsTrue();

            pauseSelectionCG.interactable = false;
            pauOpBackCG.interactable = true;

            pauseBackCG.alpha = 1;
            pauseTextCG.alpha = 1;
            pauseSelectionCG.alpha = 1;
            pauseTextTrans.localPosition = new Vector2(0, 105);
            pauseSelectionTrans.localPosition = new Vector2(0, -55);
            pauseLineTrans.localPosition = new Vector2(0, 30);
            pauseLineTrans.localScale = new Vector3(1, 1, 1);
            pauseLineTrans.localEulerAngles = new Vector3(0, 0, 0);

            pauOpTextCG.alpha = 0;
            pauOpSetTextCG.alpha = 0;
            pauOpSliderCG.alpha = 0;
            pauOpBackCG.alpha = 0;
            pauOpSetTextTrans.localPosition = new Vector2(10, 0);
            pauOpSliderTrans.localPosition = new Vector2(-10, 0);
            pauOpBackTrans.localPosition = new Vector2(0, -405);

            pauseTextCG.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauseSelectionCG.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauseTextTrans.LeanMoveLocal(new Vector2(0, 95), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauseSelectionTrans.LeanMoveLocal(new Vector2(0, -45), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauseLineTrans.LeanMoveLocal(new Vector2(-201.0998f, 9), 0.7f).setEaseInOutCubic().setIgnoreTimeScale(true);
            pauseLineTrans.LeanScale(new Vector3(0, 1, 1), 0.3f).setEaseOutCubic().setIgnoreTimeScale(true);

            yield return new WaitForSecondsRealtime(0.3f);
            pauseLineTrans.localEulerAngles = new Vector3(0, 0, 90);
            objPauseOptions.SetActive(true);

            pauOpTextCG.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauOpSetTextCG.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauOpSliderCG.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauOpBackCG.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauOpSetTextTrans.LeanMoveLocal(new Vector2(0, 0), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauOpSliderTrans.LeanMoveLocal(new Vector2(0, 0), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauOpBackTrans.LeanMoveLocal(new Vector2(0, -415), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauseLineTrans.LeanScale(new Vector3(1, 1, 1), 0.4f).setEaseInOutCubic().setIgnoreTimeScale(true);
        }
    }

    void closeOp()
    {
        StartCoroutine(closeOpAnim());

        IEnumerator closeOpAnim()
        {
            controlManager.optionsFalse();

            pauseSelectionCG.interactable = true;
            pauOpBackCG.interactable = false;

            pauseTextCG.alpha = 0;
            pauseSelectionCG.alpha = 0;
            pauseTextTrans.localPosition = new Vector2(0, 95);
            pauseSelectionTrans.localPosition = new Vector2(0, -45);
            pauseLineTrans.localPosition = new Vector2(-201.0998f, 9);
            pauseLineTrans.localScale = new Vector3(1, 1, 1);
            pauseLineTrans.localEulerAngles = new Vector3(0, 0, 90);

            pauOpTextCG.alpha = 1;
            pauOpSetTextCG.alpha = 1;
            pauOpSliderCG.alpha = 1;
            pauOpBackCG.alpha = 1;
            pauOpSetTextTrans.localPosition = new Vector2(0, 0);
            pauOpSliderTrans.localPosition = new Vector2(0, 0);
            pauOpBackTrans.localPosition = new Vector2(0, -415);

            pauOpTextCG.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauOpSetTextCG.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauOpSliderCG.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauOpBackCG.LeanAlpha(0, 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauOpSetTextTrans.LeanMoveLocal(new Vector2(10, 0), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauOpSliderTrans.LeanMoveLocal(new Vector2(-10, 0), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauOpBackTrans.LeanMoveLocal(new Vector2(0, -405), 0.3f).setEaseInCubic().setIgnoreTimeScale(true);
            pauseLineTrans.LeanScale(new Vector3(0, 1, 1), 0.3f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauseLineTrans.LeanMoveLocal(new Vector2(0, 30), 0.7f).setEaseInOutCubic().setIgnoreTimeScale(true);

            yield return new WaitForSecondsRealtime(0.3f);
            pauseLineTrans.localEulerAngles = new Vector3(0, 0, 0);
            objPauseOptions.SetActive(false);

            pauseTextCG.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauseSelectionCG.LeanAlpha(1, 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauseTextTrans.LeanMoveLocal(new Vector2(0, 105), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauseSelectionTrans.LeanMoveLocal(new Vector2(0, -55), 0.4f).setEaseOutCubic().setIgnoreTimeScale(true);
            pauseLineTrans.LeanScale(new Vector3(1, 1, 1), 0.4f).setEaseInOutCubic().setIgnoreTimeScale(true);
        }
    }
}
