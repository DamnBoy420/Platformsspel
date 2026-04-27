using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlatGameManager : MonoBehaviour
{

    [SerializeField] List<GameObject> myList;

    public void PointSpawner()
    {
        foreach (GameObject points in myList)
        {
            if (points.gameObject.CompareTag("GamePoints"))
            {
                points.gameObject.SetActive(true);
            }
        }
    }

    public void DestroyAllPoints()
    {
        Debug.Log("1");
        Debug.Log(GameObject.FindGameObjectsWithTag("GamePoints").Length);
        if (GameObject.FindGameObjectsWithTag("GamePoints").Length == 1)
        {
            Debug.Log("2");
            FindFirstObjectByType<DoorSlider>().DoorSlidering();
        }  
    }
}
