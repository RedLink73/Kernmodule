using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 1f;
    public float dampeningTime = 1f;



    public Rigidbody2D rb;

    public Camera cam;

    public float HP;
    public float MaxHP = 5;


    Vector2 movement;
    Vector2 mousePos;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        FixedUpdate();
    }


    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDirection = mousePos - rb.position;
        float targetAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90;

        float currentAngle = Mathf.SmoothDampAngle(rb.rotation, targetAngle, ref rotateSpeed, dampeningTime);

        rb.MoveRotation(currentAngle);
    }
}



