using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PodController : MonoBehaviour
{
    public FollowCamera followCamera;
    public FPSController fpsController;
    // public CreatureController cc;


    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            followCamera.enabled = true;
            fpsController.enabled = false;
            // cc.enabled = true;


        }
        else if (Input.GetKey(KeyCode.Z))
        {
            followCamera.enabled = false;
            fpsController.enabled = true;
            // cc.enabled = false;
        }

    }

}
