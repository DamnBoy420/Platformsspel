using UnityEngine;

public class StartPlatGame : MonoBehaviour
{
       
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            FindFirstObjectByType<PlatGameManager>().PointSpawner();
            var platforms = FindObjectsByType<PlatMovement>(FindObjectsSortMode.None);
            foreach (var plat in platforms)
            {
                plat.GetComponent<PlatMovement>().StartPlatMovement();
            }
        }
    } 
}
