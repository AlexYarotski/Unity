using UnityEngine;

namespace Project
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] 
        private float _moveSpeed = 0f;
        
        private Vector3 _v = Vector3.zero;

        private void FixedUpdate()
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            Vector3 moveDerection = new Vector3(horizontal, 0, vertical).normalized;

            transform.position += moveDerection * _moveSpeed * Time.deltaTime;

            if (moveDerection != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(moveDerection, transform.up);
            }
        }
    }
}
        
        
        