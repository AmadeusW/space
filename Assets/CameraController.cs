using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Target;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - Target.transform.position;
    }

    void LateUpdate()
    {
        transform.position = Target.transform.position + offset;
    }
}
