using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCursor : MonoBehaviour
{
    public int objectType;

    public ObjCursor objCursor;
    private void OnMouseOver()
    {
        objCursor.index = objectType;
        objCursor.mouseOver = true;
    }

    private void OnMouseExit()
    {
        objCursor.mouseOver = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            objCursor.index = objectType;
            objCursor.inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            objCursor.inRange = false;
        }
    }
}
