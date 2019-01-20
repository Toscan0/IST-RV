using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showInfo : MonoBehaviour {

    // Use this for initialization
    public float stare_time = 0f; // timer 
    public GameObject TargetObject;
    public GameObject info;
    //public GameObject child;

    public GameObject buttonUI;
    Renderer rend;

    private bool pressed = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("ShowInfo");
        stare_time = stare_time + Time.deltaTime;

        if (x != 0){
            pressed = true;
        }
        if (x == 0)
        {
            pressed = false;
        }

        if (stare_time > 0f){
            buttonUI.SetActive(true);
        }
        
        if (stare_time > 0f){ // once a certain amount of time has passed, the object will be 'grabbed'
            if (pressed)
            {

                showFrameInfo();
            }
            else{
                unShowFrameInfo();
            }

        }
    }


    public void ResetStareTime()
    {
        buttonUI.SetActive(false);
        info.SetActive(false);
        stare_time = 0f;
    }


    public void showFrameInfo()
    {
        info.SetActive(true);
    }
    public void unShowFrameInfo()
    {
        info.SetActive(false);
    }
}
