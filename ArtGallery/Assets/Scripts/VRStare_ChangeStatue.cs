using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRStare_ChangeStatue : MonoBehaviour {

    public float stare_time = 0f; // timer 
    public GameObject toHide;
    public GameObject toShow;

    public GameObject buttonUI;
    Renderer rend;
    
    private bool pressed = true;

    // Update is called once per frame
    void Update()
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
        else
        {
            pressed = false;
        }
        if (stare_time > 0f) // once a certain amount of time has passed, the object will be 'grabbed'
        {
            if (pressed)
            {
                    activateObject();
                }
                else
                {
                    deactivateObject();
                }
        }
    }


    public void ResetStareTime()
    {
        buttonUI.SetActive(false);
        stare_time = 0f;

        toShow.SetActive(false);
        toHide.SetActive(true);
    }


    public void activateObject()
    {
        toShow.SetActive(true);
        toHide.SetActive(false);
    }
    public void deactivateObject()
    {
        toShow.SetActive(false);
        toHide.SetActive(true);
    }
}
