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
    
    private void DestroyAllPoints()
    {
        GameObject[] points = GameObject.FindGameObjectsWithTag("GamePoints");
        foreach (GameObject p in points)
        {
            if (p != null)
            {
                FindFirstObjectByType<DoorSlider>().DoorSlidering();
            }
        }
    }
}
