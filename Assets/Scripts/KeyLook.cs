// original by asteins
// adapted by @torahhorse
// http://wiki.unity3d.com/index.php/SmoothMouseLook

// Instructions:
// There should be one MouseLook script on the Player itself, and another on the camera
// player's MouseLook should use MouseX, camera's MouseLook should use MouseY

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeyLook : MonoBehaviour
{
    #region Variables
    public bool enableCameraMovement = true;

    public float verticalRotationRange = 170;
    public float horizontalRotationRange = 180;

    public float mouseSensitivity = 10;
    public float fOVToMouseSensitivity = 1;
    public float cameraSmoothing = 5f;
    internal Vector3 cameraStartingPosition;

    public Vector3 targetAngles;
    private Vector3 followAngles;
    private Vector3 followVelocity;
    private Vector3 originalRotation;
    #endregion

    private void Awake()
    {
        originalRotation = transform.localRotation.eulerAngles;
    }

    private void Update()
    {
        if (enableCameraMovement)
        {
            float mouseXInput = 0;
            
            mouseXInput = Input.GetAxis("Horizontal Camera Keys");

            if (targetAngles.y > 180)
            {
                targetAngles.y -= 360;
                followAngles.y -= 360;
            }
            else if (targetAngles.y < -180)
            {
                targetAngles.y += 360;
                followAngles.y += 360;
            }


            if (targetAngles.x > 180)
            {
                targetAngles.x -= 360; followAngles.x -= 360;
            }
            else if (targetAngles.x < -180)
            {
                targetAngles.x += 360;
                followAngles.x += 360;
            }

            targetAngles.y += mouseXInput * (mouseSensitivity * fOVToMouseSensitivity / 6f);

            targetAngles.x = 0f;

            if (Input.GetKeyUp("p"))
            {
                print("Target angles: " + targetAngles);
                print("Follow angles: " + followAngles);
            }

            targetAngles.x = Mathf.Clamp(targetAngles.x, -0.5f * verticalRotationRange, 0.5f * verticalRotationRange);
            followAngles = Vector3.SmoothDamp(followAngles, targetAngles, ref followVelocity, (cameraSmoothing) / 100);

            //Clamp tests
            targetAngles.y = Mathf.Clamp(targetAngles.y, -0.5f * horizontalRotationRange, 0.5f * horizontalRotationRange);

            transform.localRotation = Quaternion.Euler(0, followAngles.y + originalRotation.y, 0);
        }
    }
}
