using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fMovement : MonoBehaviour {

    public GameObject Ground;
    public Quaternion diffAng, playerAngle;

    public void Start() {
        diffAng = Ground.transform.rotation;
        GameObject player = this.gameObject;
        playerAngle = player.transform.rotation;
    }
	void Update () {
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        var y = diffAng.eulerAngles - playerAngle.eulerAngles;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        Debug.Log("Player EulerY" + playerAngle.eulerAngles.y);

        transform.Rotate(diffAng.eulerAngles - playerAngle.eulerAngles);
        transform.Translate(x, y.y, z);
    }
}
