using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlObjectsByMouse : MonoBehaviour {
	//SteamVR_TrackedController trackedController;
    [SerializeField]
    GameObject grababbleObject;
    FixedJoint joint;
    
    public bool isPressed;
    public bool isUnPressed;
    
	// Use this for initialization
	void Start () {
		isPressed = false;
		isUnPressed = false;
// 		trackedController = gameObject.GetComponent<SteamVR_TrackedController> ();
//         if (trackedController == null) {
//             trackedController = gameObject.AddComponent<SteamVR_TrackedController> ();
//         }
// 
//         trackedController.TriggerClicked += new ClickedEventHandler (DoTriggerClicked);
//         trackedController.TriggerUnclicked += new ClickedEventHandler (DoTriggerUnclicked);

        joint = gameObject.GetComponent<FixedJoint> ();
	}
	
	// Update is called once per frame
	void Update () {
// 		Vector3 pos = Input.mousePosition;
//     	pos.z = 5.0f;
//     	Vector3 v = Camera.main.ScreenToWorldPoint(pos);
//     	transform.position = v;
// 		if(Input.GetMouseButtonDown(0)){
// 			grab();
// 		}
// 		if(Input.GetMouseButtonUp(0)){
// 			release();
// 		}
		if(isUnPressed){
			Debug.Log("Up");
			release();
			isPressed = false;
			isUnPressed = false;
		}
		if(isPressed){
			isUnPressed = false;
			Debug.Log("Down");
			grab();
		}
		

		
	}
	
	void grab() {
        if (grababbleObject == null || joint.connectedBody != null) {
            return;
        }

        joint.connectedBody = grababbleObject.GetComponent<Rigidbody> ();
    }

    void release() {
        if (joint.connectedBody == null) {
            return;
        }

        joint.connectedBody = null;
    }
    
    void OnTriggerEnter(Collider other) {
    	Debug.Log("enter");
        grababbleObject = other.gameObject;
    }

    void OnTriggerExit(Collider other) {
    	Debug.Log("exit");
        grababbleObject = null;
    }
    
    
}
