using UnityEngine;

public class DoorSlider : MonoBehaviour
{
    [SerializeField] private Vector2 velocity;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    private void StartDoorSlider()
    {
        
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
