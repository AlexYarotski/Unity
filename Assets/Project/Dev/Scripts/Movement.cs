using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0;

    [SerializeField]
    private float _acceleration = 0f;

    private Vector3 _moveDirection = Vector3.zero;

    private Rigidbody _rigidbody = null;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _moveDirection = new Vector3(1, 0, 0);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            _moveDirection = new Vector3(-1, 0, 0);
        }
        else
        {
            _moveDirection = Vector3.zero;
        }

        var desiredVelocity = _moveDirection * _speed;
        
        _rigidbody.AddForce(desiredVelocity);
    }
}
