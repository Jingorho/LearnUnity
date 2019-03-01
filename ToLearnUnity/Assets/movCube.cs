using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movCube : MonoBehaviour {
	/*
	//これらは全てローカル座標での（オブジェクトに対して相対的に，自分自身での）ベクトル，軸．
	//rightだったら，オブジェクト自身にとっての右．ワールドの右じゃない．オブジェクトが回転したら，
	//Vector3.rightも回転（=変化）する．

	forward	Vector3(0, 0, 1) と同じ意味
	back	Vector3(0, 0, -1) と同じ意味
	up		Vector3(0, 1, 0) と同じ意味
	down	Vector3(0, -1, 0) と同じ意味
	right	Vector3(1, 0, 0) と同じ意味．
	left	Vector3(-1, 0, 0) と同じ意味
	one		Vector3(1, 1, 1) と同じ意味
	zero	Vector3(0, 0, 0) と同じ意味
	negativeInfinity	Shorthand for writing Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity).
	positiveInfinity	Shorthand for writing Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity).

	*/
	public bool _forward, _back, _up, _down, _right, _left, _one, _zero = false;
	public bool _position, _rotation;

	public Vector3 localPos;
	public Vector3 globalPos;
	public Vector3 localRot;
	public Vector3 globalRot;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		localPos = transform.localPosition;
		globalPos = transform.position;
		localRot = transform.localEulerAngles;
		globalRot = transform.eulerAngles;
			
		if (_position) {
			///////////////////////////////////////////////
			// POSITION
			///////////////////////////////////////////////
			if (_forward) {
				transform.position = Vector3.forward;
			}
			if (_back) {
				transform.position = Vector3.back;
			}
			if (_up) {
				transform.position = Vector3.up;
			}
			if (_down) {
				transform.position = Vector3.down;
			}
			if (_right) {
				transform.position = Vector3.right;
			}
			if (_left) {
				transform.position = Vector3.left;
			}
			if (_one) {
				transform.position = Vector3.one;
			}
			if (_zero) {
				transform.position = Vector3.zero;
			}
		}

		if (_rotation) {
			///////////////////////////////////////////////
			// ROTATION
			///////////////////////////////////////////////
			if (_forward) {
				transform.Rotate(Vector3.forward);
			}
			if (_back) {
				transform.Rotate(Vector3.back);
			}
			if (_up) {
				transform.Rotate(Vector3.up);
			}
			if (_down) {
				transform.Rotate(Vector3.down);
			}
			if (_right) {
				transform.Rotate(Vector3.right);
			}
			if (_left) {
				transform.Rotate(Vector3.left);
			}
			if (_one) {
				transform.Rotate(Vector3.one);
			}
			if (_zero) {
				transform.Rotate(Vector3.zero);
			}
		}

//		if (!_position && _rotation) {
//			transform.position = Vector3.zero;
//			transform.Rotate (Vector3.zero);
//		}

	}//Update
}
