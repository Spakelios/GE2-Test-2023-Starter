using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodController : MonoBehaviour
{
    public FollowCamera followCamera;
    public FPSController fpsController;

    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            followCamera.enabled = true;
            fpsController.enabled = false;
        }
        else if(Input.GetKey(KeyCode.Z))
        {
            followCamera.enabled = false;
            fpsController.enabled = true;
        }
    }

}
