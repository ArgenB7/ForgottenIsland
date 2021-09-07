using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Screenshot : MonoBehaviour
{
    public new string name = "Screenshot ";
    public int i = 1;
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            print("space key was pressed");
            ScreenCapture.CaptureScreenshot(name+i+".png");
            i++;
        }
    }
}
