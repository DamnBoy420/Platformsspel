using UnityEngine;

public class EndPoints : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Moving Platform"))
        {
            other.gameObject.GetComponent<PlatMovement>().PlatformMovement();
        }
        
    }
}
