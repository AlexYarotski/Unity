using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal * _speed, 0, 0);
        _rb.AddForce(movement * _speed);
    }
}
