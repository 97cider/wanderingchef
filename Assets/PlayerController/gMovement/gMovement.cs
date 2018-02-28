using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class gMovement : MonoBehaviour {

    public GameObject player;
    private BoxCollider playerCollider;
    public GameObject startingTile;
    private Vector2Int position;
    private GameObject currentTile;
    public GameObject worldEnd;
    void Start() {
        player.transform.position = startingTile.transform.position + new Vector3(0,1.3f,0);
        currentTile = startingTile;
    }

    public bool checkNorth (GameObject tile)
    {
        if (tile.GetComponent<tileLayout>().nTile.tag != "Water" && tile.GetComponent<tileLayout>().nTile != worldEnd)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool checkSouth(GameObject tile)
    {
        if (tile.GetComponent<tileLayout>().sTile.tag != "Water" && tile.GetComponent<tileLayout>().sTile != worldEnd)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool checkWest(GameObject tile)
    {
        if (tile.GetComponent<tileLayout>().wTile.tag != "Water" && tile.GetComponent<tileLayout>().wTile != worldEnd)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool checkEast(GameObject tile)
    {
        if (tile.GetComponent<tileLayout>().eTile.tag != "Water" && tile.GetComponent<tileLayout>().eTile != worldEnd)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
   
    public void MoveNorth()
    {
        if (checkNorth(currentTile))
        {
            Debug.Log("Player can move to the north");
            player.transform.position = currentTile.GetComponent<tileLayout>().nTile.transform.position + new Vector3(0, 1.3f, 0);
            currentTile = currentTile.GetComponent<tileLayout>().nTile;
        }
        else
        {
            Debug.Log("Player cannot move to the north");
        }
    }
    public void MoveSouth()
    {
        if (checkSouth(currentTile))
        {
            Debug.Log("Player can move to the south");
            player.transform.position = currentTile.GetComponent<tileLayout>().sTile.transform.position + new Vector3(0, 1.3f, 0);
            currentTile = currentTile.GetComponent<tileLayout>().sTile;
        }
        else
        {
            Debug.Log("Player cannot move to the sout");
        }
    }

    public void MoveWest()
    {
        if (checkWest(currentTile))
        {
            Debug.Log("Player can move to the west");
            player.transform.position = currentTile.GetComponent<tileLayout>().wTile.transform.position + new Vector3(0, 1.3f, 0);
            currentTile = currentTile.GetComponent<tileLayout>().wTile;
        }
        else
        {
            Debug.Log("Player cannot move to the west");
        }
    }

    public void MoveEast() {
        if (checkEast(currentTile))
        {
            Debug.Log("Player can move to the east");
            player.transform.position = currentTile.GetComponent<tileLayout>().eTile.transform.position + new Vector3(0, 1.3f, 0);
            currentTile = currentTile.GetComponent<tileLayout>().eTile;
        }
        else
        {
            Debug.Log("Player cannot move to the east");
        }
    }
    void Update()
    {
        Vector2 joystickPos = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical"));
    }
}
