using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			RotationSpin ();
		}
	}

	void RotationSpin(){
//		Vector3 rotAxis = GameObject.Find ("Cube_wh").transform.forward;
		Vector3 rotAxis = new Vector3(
			GameObject.Find ("axis").transform.eulerAngles.x,
			GameObject.Find ("axis").transform.eulerAngles.y,
			GameObject.Find ("axis").transform.eulerAngles.z
		);
		transform.RotateAround (
			GameObject.Find("Cube_wh").transform.position,
			rotAxis,
			30*Time.deltaTime
		);
		Debug.Log (rotAxis);
		
		GameObject.Find ("axisVec").transform.eulerAngles = rotAxis;
		
	}//RotationSpin()
	
	

}
