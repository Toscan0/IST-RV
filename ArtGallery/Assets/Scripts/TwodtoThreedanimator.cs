using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwodtoThreedanimator : MonoBehaviour {

    // Use this for initialization
    public float stare_time = 0f; // timer 
    public GameObject TargetObject;
    public Material[] materials;
    public GameObject child;

    public GameObject buttonUI;
    Renderer rend;

    private bool active = false;

    private bool pressed = false;

    // Update is called once per frame
    void Update () {

     float x = Input.GetAxis("Active");
     stare_time = stare_time + Time.deltaTime;


    if (x!=0 )
        {
            active = !active;
            pressed = true;
        }
        else  { pressed = false; }
        
    if (stare_time > 0f)
        {
            buttonUI.SetActive(true);
        }

    if (stare_time > 0f & pressed) // once a certain amount of time has passed, the object will be 'grabbed'
    {
       
        activateObject();
        

     }
    if (pressed == false)
        {
            deactivateObject();
        }
}


    public void ResetStareTime()
    {
        buttonUI.SetActive(false);
        stare_time = 0f;

        pressed = false;
        deactivateObject();
    }


    public void activateObject()
    {        
        TargetObject.GetComponent<Renderer>().material = materials[0];
        child.SetActive(true);
    }
    public void deactivateObject()
    {
        TargetObject.GetComponent<Renderer>().material = materials[1];
        child.SetActive(false);
    }

}
