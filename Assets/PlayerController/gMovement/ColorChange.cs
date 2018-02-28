using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ColorChange : MonoBehaviour {
    public Color colorChoice;
    public GameObject tile;
    void Start()
    {
       Renderer tileRenderer = tile.GetComponent<Renderer>();
       tileRenderer.material.color = colorChoice;
    }
}
    