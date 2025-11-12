using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        int numberOfInstances = FindObjectsByType<DontDestroy>(FindObjectsSortMode.None).Length;
        DontDestroyOnLoad(this);
    }
}
