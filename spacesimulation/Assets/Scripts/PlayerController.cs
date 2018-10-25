using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))] //calling playermotor script

public class PlayerController : MonoBehaviour {

    public float speed = 5f;
    public float LookSensitivity = 3f; 

    private PlayerMotor motor;

    void Start()
    {
        motor = GetComponent<PlayerMotor>(); 
    }

    private void Update()
    {
        //player movement
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        Vector3 MoveHorizontal = transform.right * xMove;
        Vector3 MoveVertical = transform.forward * zMove;
        Vector3 _velocity = (MoveHorizontal + MoveVertical).normalized * speed; 
        motor.Move(_velocity); //Move, defined in PlayerMotor

        //playerrotation
        float yRot = Input.GetAxisRaw("Mouse X");
        Vector3 _rotation = new Vector3(0f, yRot, 0f) * LookSensitivity; 
        motor.Rotate(_rotation);


        //camerarotation 
        float xRot = Input.GetAxisRaw("Mouse Y");
        Vector3 _cameraRotation = new Vector3(xRot, 0f, 0f) * LookSensitivity;
        motor.RotateCamera(_cameraRotation);

    }
}
