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
        if (GameObject.FindGameObjectsWithTag("GamePoints").Length == 1)
        {
            FindFirstObjectByType<DoorSlider>().SecDoorSlider();
        }  
    }
}
