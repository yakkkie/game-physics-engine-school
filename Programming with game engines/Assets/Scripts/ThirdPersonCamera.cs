using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{

    public Transform mPlayer;

    TPCbase mThirdPersonCamera;

    void Start()
    {
        mThirdPersonCamera = new TPCTrack(transform, mPlayer);
    }

    void LateUpdate()
    {
        mThirdPersonCamera.Update();
    }

}
