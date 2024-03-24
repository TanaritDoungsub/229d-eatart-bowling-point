using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public Transform targetObject;
    public Vector3 cameraOffset;

    private void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position;

    }
    private void LateUpdate()
    {
        Vector3 newPosition = targetObject.transform.position + cameraOffset;
        transform.position = newPosition;
    }
}
