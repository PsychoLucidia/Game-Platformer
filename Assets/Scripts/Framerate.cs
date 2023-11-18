using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Framerate : MonoBehaviour
{
    public int framePerSec;
    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = framePerSec;
    }
}
