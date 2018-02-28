using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileLayout : MonoBehaviour {
    public GameObject tile;
    public GameObject wTile, nTile, eTile, sTile;
    public GameObject worldEnd;

    void Start()
    {
        if (wTile == null)
        {
            wTile = worldEnd;
        }
        if (nTile == null)
        {
            nTile = worldEnd;
        }
        if (eTile == null)
        {
            eTile = worldEnd;
        }
        if (sTile == null)
        {
            sTile = worldEnd;
        }
    }	
}
