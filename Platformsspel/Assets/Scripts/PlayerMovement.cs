using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PlayerMovement : MonoBehaviour
{
    private bool isGrounded;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpForce = 20f;
    [SerializeField] private ContactFilter2D groundFilter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(moveInput.x * moveSpeed, rb.linearVelocity.y);
    }

    private void FixedUpdate()
    {
        isGrounded = rb.IsTouching(groundFilter);
    }

    void OnJump()
    {
        Jump();
    }

    private void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
