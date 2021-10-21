using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDirMove : MonoBehaviour
{
    public float moveSpeed = 1;
    private CharacterController controller;

    public float gravity = 10.0f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //reading the input:
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        //assuming we only using the single camera:
        Transform cameraTransform = Camera.main.transform;

        //camera forward and right vectors:
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        //project forward and right vectors on the horizontal plane (y = 0)
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        //this is the direction in the world space we want to move:
        Vector3 desiredMoveDirection = forward * verticalAxis + right * horizontalAxis;
        //Vector3 desiredMoveDirection = forward * horizontalAxis + right * verticalAxis;
        //  Vector3 desiredMoveDirection = forward * horizontalAxis + -right * verticalAxis;

        //now we can apply the movement:
        //transform.Translate(desiredMoveDirection * moveSpeed * Time.deltaTime);

        desiredMoveDirection.y -= gravity * Time.deltaTime;

        controller.Move(desiredMoveDirection * moveSpeed * Time.deltaTime);
    }
}
