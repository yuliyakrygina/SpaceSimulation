using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))] //calling playermotor script

public class PlayerController : MonoBehaviour {

    public float speed = 5f;
    public float LookSensitivity = 3f;

    private PlayerMotor motor;

    void Start() //DO
    {
        motor = GetComponent<PlayerMotor>();
    }

    private void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        Vector3 MoveHorizontal = transform.right * xMove;
        Vector3 MoveVertical = transform.forward * zMove;

        Vector3 _velocity = (MoveHorizontal + MoveVertical).normalized * speed;

        //apply movement
        motor.Move(_velocity);

        float yRot = Input.GetAxisRaw("Mouse X");
        Vector3 _rotation = new Vector3(0f, yRot, 0f) * LookSensitivity;

        //apply rotation to player
        motor.Rotate(_rotation);

        //calculate rotation as a 3D vector; turning around
        float xRot = Input.GetAxisRaw("Mouse Y");
        Vector3 _cameraRotation = new Vector3(xRot, 0f, 0f) * LookSensitivity;
        
        //apply rotation to camera
        motor.RotateCamera(_cameraRotation);

    }
}
