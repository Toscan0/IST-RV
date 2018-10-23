using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentPlayer : MonoBehaviour
{


    public float moveSpeed;
    private Vector3 direction;
    public Transform VRcamera;

    public const float toggleAngle = 30.0f;
    public bool moveForward;
    public bool moveBackward;

    private CharacterController cc;

    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
  
        if (VRcamera.eulerAngles.x >= toggleAngle && VRcamera.eulerAngles.x < 90){
            moveForward = true;
            moveBackward = false;
        }
        else if (VRcamera.eulerAngles.x >= 270 && VRcamera.eulerAngles.x < 330)
        {
            moveBackward = true;
            moveForward = false;
        }
        else{
            moveForward = false;
            moveBackward = false;
        }

        if (moveForward){
            direction = Camera.main.transform.forward;
            transform.Translate(direction[0] * moveSpeed * Time.deltaTime, 0f, direction[2] * moveSpeed * Time.deltaTime);

            //Vector3 forward = VRcamera.TransformDirection(Vector3.forward);
            //cc.SimpleMove(forward * moveSpeed);
        }
        else if (moveBackward){
            
            direction = -Camera.main.transform.forward;
            transform.Translate(direction[0] * moveSpeed * Time.deltaTime, 0f, direction[2] * moveSpeed * Time.deltaTime);
        }
        else{
            //transform.Translate(0, 0 , 0);
        }
    }
}
