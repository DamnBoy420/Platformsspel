using UnityEngine;

public class LevelExit : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindFirstObjectByType<LevelManager>().LoadNextLevel();
        }
    }
}
