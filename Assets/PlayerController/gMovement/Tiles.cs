using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour {
    public GameObject Ground;
    public List<List<GameObject>> tileMatrix;
    public static GameObject player;
    public int rowLength;
    private GameObject[] childObjs;

    void Start()
    {
        childObjs = Ground.GetComponentsInChildren<GameObject>();
        foreach (GameObject child in childObjs)
        {
            while (rowLength < 4)
            {
                tileMatrix[0].Add(child);
                rowLength++;
            }
            while (rowLength > 3 && rowLength < 8)
            {
                tileMatrix[1].Add(child);
                rowLength++;
            }
        }
    }
}
