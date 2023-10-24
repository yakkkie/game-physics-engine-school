using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TPCbase : MonoBehaviour
{
    protected Transform mCameraTransform;
    protected Transform mPlayerTransform;


    public Transform CameraTransform
    {
        get
        {
            return mCameraTransform;
        }
    }
    public Transform PlayerTransform
    {
        get
        {
            return mPlayerTransform;
        }
    }

    // Update is called once per frame
    public abstract void Update();

    public TPCbase(Transform cameraTransform, Transform playerTransform)
    {
        mCameraTransform = cameraTransform;
        mPlayerTransform = playerTransform;
    }

}
