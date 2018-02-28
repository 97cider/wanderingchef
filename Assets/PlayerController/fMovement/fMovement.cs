using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class fMovement : MonoBehaviour {

    public GameObject Ground;
    public Quaternion diffAng, playerAngle;

    public void Start() {
        diffAng = Ground.transform.rotation;
        GameObject player = this.gameObject;
        playerAngle = player.transform.rotation;
    }
	void Update () {
        Vector2 joystickPos = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical"));
        var z = joystickPos.x * Time.deltaTime * 3.0f;
        var x = joystickPos.y * Time.deltaTime * 3.0f;
        //var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        //var y = diffAng.eulerAngles - playerAngle.eulerAngles;
        //var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        //Debug.Log("Player EulerY" + playerAngle.eulerAngles.y);

        //transform.Rotate(diffAng.eulerAngles - playerAngle.eulerAngles);
        transform.Translate(z, 0, x);
    }
}
