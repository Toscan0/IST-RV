using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentPlayer : MonoBehaviour
{


    public float moveSpeed;
    public Vector3 direction;

    public bool moveForward;
    public bool moveBackward;
    public bool moveRight;
    public bool moveLeft;


    public bool rotateForward;
    public bool rotateBackward;

    // Update is called once per frame
    void Update()
    {
        GameObject camera = GameObject.Find("Camera");
        GameObject player = GameObject.Find("Player");

        direction = camera.transform.forward;
        float hz = Input.GetAxis("Vertical");
        float hx = Input.GetAxis("Horizontal");
        
        float t = Input.GetAxis("Turn");
        if (hz > 0)
        {
            moveForward = true;
            moveBackward = false;
        }
        else if (hz < 0)
        {
            moveBackward = true;
            moveForward = false;
        }
        else
        {
            moveForward = false;
            moveBackward = false;
        }
        if (hx > 0)
        {
            moveRight = true;
            moveLeft = false;
        }
        else if (hx < 0)
        {
            moveLeft = true;
            moveRight = false;
        }
        else
        {
            moveLeft = false;
            moveRight = false;
        }

        if (moveForward)
        {
            direction = camera.transform.forward;
            transform.Translate(direction[0] * moveSpeed * Time.deltaTime, 0f, direction[2] * moveSpeed * Time.deltaTime);

        }
        if (moveBackward)
        {

            direction = -camera.transform.forward;
            transform.Translate(direction[0] * moveSpeed * Time.deltaTime, 0f, direction[2] * moveSpeed * Time.deltaTime);
        }

        if (moveLeft)
        {
            direction = camera.transform.forward;
            direction = Quaternion.Euler(0, -90, 0) * direction;
            transform.Translate(direction[0] * moveSpeed * Time.deltaTime, 0f, direction[2] * moveSpeed * Time.deltaTime);

        }
        if (moveRight)
        {

            direction = -camera.transform.forward;
            direction = Quaternion.Euler(0, -90, 0) * direction;
            transform.Translate(direction[0] * moveSpeed * Time.deltaTime, 0f, direction[2] * moveSpeed * Time.deltaTime);
        }

        else
        {
            //transform.Translate(0, 0 , 0);
        }



        if (t != 0)
        {
            direction = camera.transform.forward;
            direction = Quaternion.Euler(0, -180, 0) * direction;
            camera.transform.forward = direction;
        }

    }
}
