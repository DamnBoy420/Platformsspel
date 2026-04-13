using UnityEngine;

public class PlatMovement : MonoBehaviour
{
    [SerializeField] private float platMoveSpeed = 4f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void StartPlatMovement()
    {
        platMoveSpeed = 4f;
    }

    private void Update()
    {
        rb.linearVelocity = new Vector2(platMoveSpeed, rb.linearVelocity.y);
    }

    public void PlatformMovement()
    {
        platMoveSpeed = -platMoveSpeed;
    }
}
