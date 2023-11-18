using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camOffset : MonoBehaviour
{
    CinemachineVirtualCamera offsetCam;
    private float xValue;
    // Start is called before the first frame update
    void Start()
    {
        offsetCam = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
