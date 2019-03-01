using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCube : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.position = GameObject.Find ("Cube_wh").transform.position;
//		transform.rotation = GameObject.Find ("Cube_wh").transform.rotation;
	}
}
