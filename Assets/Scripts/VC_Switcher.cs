using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VC_Switcher : MonoBehaviour
{
    public GameObject[] vcCameras;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (vcCameras[0].active)
            {
                vcCameras[0].active = false;
                vcCameras[1].active = true;
            } else
            {
                vcCameras[1].active = false;
                vcCameras[0].active = true;
            }
        }
    }
}
