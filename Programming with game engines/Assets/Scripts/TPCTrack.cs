using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPCTrack : TPCbase
{

    public TPCTrack(Transform cameraTransform, Transform playerTransform)
        : base(cameraTransform, playerTransform)
    {
    }


    // Update is called once per frame
    public override void Update()
    {
        Vector3 targetPos = mPlayerTransform.position;
        mCameraTransform.LookAt(targetPos);

    }
}
