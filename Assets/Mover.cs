using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    Vector3 previousLocation;
    Vector3 moveDirection;
 
    void Update ()
    {
        moveDirection = Vector3.zero;
        previousLocation = transform.position;
        if (Input.GetKey (KeyCode.UpArrow)) moveDirection.y = 1;
        if (Input.GetKey (KeyCode.DownArrow)) moveDirection.y = -1;
        if (Input.GetKey (KeyCode.LeftArrow)) moveDirection.x = -1;
        if (Input.GetKey (KeyCode.RightArrow)) moveDirection.x = 1;
 
        transform.position = Vector3.Lerp(transform.position, transform.position +
        moveDirection.normalized, Time.fixedDeltaTime * moveSpeed);
 
        if (moveDirection != Vector3.zero)
        transform.rotation = Quaternion.Lerp(
        transform.rotation, Quaternion.LookRotation(transform.position - previousLocation),
        Time.fixedDeltaTime * rotationSpeed);
     }
}