using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingIconTween : MonoBehaviour
{
    public CanvasGroup iconCG;
    public Transform loadingCircleTrans;
    // Start is called before the first frame update
    void Start()
    {
        iconCG.alpha = 1.0f;
        iconCG.LeanAlpha(0.5f, 1).setRepeat(-1).setLoopPingPong().setEaseInCubic().setIgnoreTimeScale(true);

        loadingCircleTrans.localEulerAngles = new Vector3(0, 0, 0);
        loadingCircleTrans.LeanRotateAround(Vector3.forward, -360, 1).setRepeat(-1).setIgnoreTimeScale(true);
    }
}
