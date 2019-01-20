using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showSoundHelp : MonoBehaviour
{
    public GameObject rawImage;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            rawImage.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            rawImage.SetActive(true);
        }
    }
}
