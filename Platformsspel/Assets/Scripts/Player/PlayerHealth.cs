using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int playerHealth = 3;
    [SerializeField] float invinsibleTime = 2f;
    private bool isInvinsible;
    private int startingHealth;
    void Start()
    {
        startingHealth = playerHealth;
    }
    void ResetInvinsibility()
    {
        isInvinsible = false;
    }

    public void ResetHealth()
    {
        playerHealth = startingHealth;
    }
    public void ChangeHealth()
    {
        if (playerHealth <= 0)
        {
            FindFirstObjectByType<LevelManager>().RestartScene();
        }
        else if (!isInvinsible)
        {
            playerHealth--;
            isInvinsible = true;
            Invoke("ResetInvinsibility", invinsibleTime);
            Debug.Log("Player health:" + playerHealth);
        }
    }
}
