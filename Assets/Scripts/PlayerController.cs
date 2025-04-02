using UnityEngine;

namespace CursorTest
{
    public class PlayerController : MonoBehaviour
    {
        public float moveSpeed = 5f;
        private Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            float moveInput = 0f;
            
            if (Input.GetKey(KeyCode.A))
            {
                moveInput = -1f;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                moveInput = 1f;
            }

            Vector3 movement = new Vector3(moveInput * moveSpeed, rb.velocity.y, 0f);
            rb.velocity = movement;
        }
    }
}