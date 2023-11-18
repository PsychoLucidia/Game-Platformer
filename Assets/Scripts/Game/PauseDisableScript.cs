using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseDisableScript : MonoBehaviour
{
    private PlayerControl controls;
    private GameObject playerObject;

    private void Awake()
    {
        playerObject = GameObject.Find("Player");
        controls = playerObject.GetComponent<PlayerControl>();
    }
    public void disableMovement()
    {
        controls.enabled = false;
    }

    public void enableMovement()
    {
        controls.enabled = true;
    }
}
