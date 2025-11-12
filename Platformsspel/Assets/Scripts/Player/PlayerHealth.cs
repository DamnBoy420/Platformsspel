using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] int playerHealth = 5;
    [SerializeField] float invinsibleTime = 3f;
    bool isInvinsible;

    void ResetInvinsibility()
    {
        isInvinsible = false;
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
