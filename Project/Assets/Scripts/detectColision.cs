using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectColision : MonoBehaviour {

    /*// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("----------Enter---------");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("----------Stay---------");
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("----------whut---------");
    }
}
