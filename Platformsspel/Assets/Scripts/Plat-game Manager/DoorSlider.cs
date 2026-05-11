using UnityEngine;

public class DoorSlider : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector2 targetPosition;
    [SerializeField] private Vector2 targetPosition2;
    private bool isFirstDoorSliderActive = false;
    private bool isSecDoorSliderActive = false;

    private void Update()
    {
        if (isFirstDoorSliderActive == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }

        if (isSecDoorSliderActive == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition2, moveSpeed * Time.deltaTime);
        }
    }

    public void FirstDoorSlider()
    {
        isFirstDoorSliderActive = true;
    }

    public void SecDoorSlider()
    {
        isFirstDoorSliderActive = false;
        isSecDoorSliderActive = true;
    }
}
