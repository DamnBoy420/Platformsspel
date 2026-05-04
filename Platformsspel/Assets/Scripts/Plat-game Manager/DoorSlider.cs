using UnityEngine;

public class DoorSlider : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector2 targetPosition;

    private void StartDoorSlider()
    {
        
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    public void FirstDoorSlider()
    {
        StartDoorSlider();
    }

    public void SecDoorSlider()
    {
        StartDoorSlider();
    }
}
