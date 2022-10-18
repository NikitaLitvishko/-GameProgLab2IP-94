using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    [SerializeField] private Vector3 _distanceFromObject;

    private void LateUpdate()
    {
        transform.position = _object.transform.position + _distanceFromObject;
        transform.LookAt(_object.transform.position);
    }
}
