using UnityEngine;

public class EndPoints : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collision1");
        if (other.gameObject.CompareTag("Moving Platform"))
        {
            other.gameObject.GetComponent<PlatMovement>().PlatformMovement();
            Debug.Log("collision2");
        }
        
    }
}
