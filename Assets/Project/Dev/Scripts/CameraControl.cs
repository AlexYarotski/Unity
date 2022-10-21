using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    private Transform _babkaTransform = null;

    [SerializeField]
    private Vector3 _offset = Vector3.zero;

    void FixedUpdate()
    {
        Vector3 finalPosition = _offset + _babkaTransform.position;
        transform.position = finalPosition;
    }
}
