using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StareDisappear : MonoBehaviour
{

    public float stare_time = 0f; // timer 
    public GameObject TargetObject;
    public GameObject child;
    public GameObject other;


    public GameObject buttonUI;
    Renderer rend;

    public bool active = false;

    public bool pressed = false;

    public bool doOnceF = false;

    public bool doOnceR = false;

    public bool done = false;

    public bool inside = false;

    void OnTriggerEnter(Collider other)
    {
        inside = true;

        buttonUI.SetActive(false);
    }
    void OnTriggerExit(Collider other)
    {
        inside = false;
        if (stare_time > 0)
        {
            buttonUI.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!inside)
        {
            float x = Input.GetAxis("Active");
            stare_time = stare_time + Time.deltaTime;
            if (stare_time > 0f)
            {
                buttonUI.SetActive(true);
            }

            if (x != 0)
            {
                pressed = true;
            }
            else { pressed = false; }
            if (stare_time > 0f) // once a certain amount of time has passed, the object will be 'grabbed'
            {
                if (pressed && done == false)
                {
                    if (active == true && doOnceF == false)
                    {
                        deactivateObject();
                    }
                    else if (active == false && doOnceR == false)
                    {
                        activateObject();
                    }
                    done = true;
                }
                else if (!pressed)
                {
                    done = false;
                }
            }
        }
    }


    public void ResetStareTime()
    {
        buttonUI.SetActive(false);
        stare_time = 0f;
    }


    public void activateObject()
    {
        child.SetActive(true);
        TargetObject.SetActive(false);
        doOnceR = true;
        doOnceF = false;
        active = true;
    }

    public void deactivateObject()
    {
        child.SetActive(false);
        TargetObject.SetActive(true);
        doOnceR = false;
        doOnceF = true;
        active = false;
    }
}
