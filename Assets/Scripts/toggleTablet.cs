using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleTablet : MonoBehaviour
{
    public GameObject tablet;
    private bool toggled;

    // Start is called before the first frame update
    void Start()
    {
        tablet.SetActive(false);
        toggled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (toggled)
            {
                tablet.SetActive(false);
                toggled = false;
            } else
            {
                tablet.SetActive(true);
                toggled = true;
            }
        }
    }
}
