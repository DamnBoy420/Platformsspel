using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Collider2D feet;
    private Collider2D body;

    void Start()
    {
        feet = GetComponent<CapsuleCollider2D>();
        body = GetComponent<BoxCollider2D>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (feet.IsTouchingLayers(LayerMask.GetMask("Enemy")))
        {
            Destroy(collision.gameObject);
        }
        else if (body.IsTouchingLayers(LayerMask.GetMask("Enemy")))
        {
            FindFirstObjectByType<PlayerHealth>().ChangeHealth();
        }
    }
}
