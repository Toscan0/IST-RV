using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerMinotaur : MonoBehaviour
{
    public Animator anim;
    public bool Hit;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Hit) { anim.Play("Get_Hit");
            Hit = false;
        }
    }
   

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "Spear")
        {
            Hit = true;
        }
    }
    /*
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Spear")
        {
            Hit = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Spear")
        {
            Hit = true;
        }
    }*/
}
