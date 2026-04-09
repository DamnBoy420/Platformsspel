using UnityEngine;

public class PlatMovement : MonoBehaviour
{
    [SerializeField] private float platMoveSpeed = 4f;
    private Rigidbody2D rb;

    private void Update()
    {
        
    }

    public void StartPlatMovement()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(platMoveSpeed, rb.linearVelocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("End Point"))
        {
            PlatformMovement();
        }
    }

    public void PlatformMovement()
    {
        platMoveSpeed = -platMoveSpeed;
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }
}
