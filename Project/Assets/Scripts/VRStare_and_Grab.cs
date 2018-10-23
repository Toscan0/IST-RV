using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRStare_and_Grab : MonoBehaviour {

    public float stare_time = 0f; // timer 
    public Transform VRHand;
    public Rigidbody TargetObject;
    private Vector3 parentPos;

    private Vector3 direction;
    private bool grabbed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        stare_time = stare_time + Time.deltaTime;
        if (stare_time >= 2f) // once a certain amount of time has passed, the object will be 'grabbed'
        {
            Debug.Log("grab");
            GrabObject();
            grabbed = true;
        }
	}

    public void ResetStareTime()
    {
        stare_time = 0f;
    }

    public void GrabObject()
    {
        //TargetObject.transform.Rotate(90, 0, 0);
        parentPos = GameObject.Find("Camera").transform.position;
        TargetObject.transform.position = new Vector3(parentPos.x, parentPos.y - 1, parentPos.z);
        TargetObject.transform.parent = VRHand.transform;
        TargetObject.transform.localEulerAngles = new Vector3(90, 0, 0);
        /*
        if (!grabbed) {

            Vector3 aux = GameObject.Find("Camera").transform.forward;
            direction = Camera.main.transform.forward;

            float angle = Mathf.DeltaAngle(Mathf.Atan2(direction[0], direction[2]) * Mathf.Rad2Deg,
                                Mathf.Atan2(0, 1) * Mathf.Rad2Deg);
            TargetObject.transform.Rotate(0,angle,0);
            Debug.Log(angle);          
        }*/

    }
}
