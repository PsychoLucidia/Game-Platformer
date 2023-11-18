using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameTween : MonoBehaviour
{
    public CanvasGroup igBlkOverlayCanGro, lifebarCanGro;
    public GameObject objBlkOverlay;

    // Start is called before the first frame update
    void Start()
    {
        objBlkOverlay.SetActive(true);
        StartCoroutine(startAnim());
    }

    IEnumerator startAnim()
    {
        igBlkOverlayCanGro.alpha = 1.0f;
        lifebarCanGro.alpha = 0;

        igBlkOverlayCanGro.LeanAlpha(0, 1).setIgnoreTimeScale(true);

        yield return new WaitForSecondsRealtime(1f);
        objBlkOverlay.SetActive(false);
        lifebarCanGro.LeanAlpha(1, 0.5f).setEaseOutCubic().setIgnoreTimeScale(true);
    }
}
