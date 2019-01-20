using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StareRotate : MonoBehaviour {
    public float stare_time = 0f; // timer 
    public GameObject TargetObject;
    private int rotateAngle = -28;
    private double scale = 1.0;

    public GameObject buttonUI;

    Renderer rend;

    private bool active = false;
    public bool rotateRight;
    public bool rotateLeft;

    public bool scaleR;
    public bool scaleL;


    // Update is called once per frame
    void Update () {

        float x = Input.GetAxis("Rotate");

        float y = Input.GetAxis("Scale");


        stare_time = stare_time + Time.deltaTime;
        if (stare_time > 0f)
        {
            buttonUI.SetActive(true);
            active = true;
        }

        if (x < 0)
        {
            rotateRight = false;
            rotateLeft = true;
            rotateAngle += -1;

        }
        if (x > 0)
        {
            rotateRight = true;
            rotateLeft = false;
            rotateAngle += 1;
            
        }

        else //no input
        {
        }
        if (y < 0)
        {
            scaleR = false;
            scaleL = true;
            scale += -0.008;

        }
        if (y > 0)
        {

            scaleR = true;
            scaleL = false;
            scale += 0.008;
        }
        if (stare_time > 0f) // once a certain amount of time has passed, the object will be 'grabbed'
        {
            if (active & (rotateLeft || rotateRight))
            {
                rotateObject();
            }
            if (active & (scaleL || scaleR))
            {
                if(scale > 1) { scale = 1.0; }
                if(scale < 0.2) { scale = 0.2; }
                scaleObject();
            }
        }
        else
        {
            active = false;
            rotateLeft = false;
            rotateRight = false;

        }

    }

    public void ResetStareTime()
    {
        stare_time = 0f;

        buttonUI.SetActive(false);
    }
    void rotateObject()
    {
       TargetObject.transform.rotation = Quaternion.Euler(0, rotateAngle, 0);
    }
    void scaleObject()
    {
        TargetObject.transform.localScale = new Vector3 ((float)scale,(float)scale,(float)scale);
    }
}
