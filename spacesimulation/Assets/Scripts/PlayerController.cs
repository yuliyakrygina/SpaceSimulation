using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{

    public float speed;

    public float LookSensitivity;

    private PlayerMotor motor;

    void Start()
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
        motor.Move(_velocity);


        float yRot = Input.GetAxisRaw("Mouse X");
        Vector3 _rotation = new Vector3(0f, yRot, 0f) * LookSensitivity;
        motor.Rotate(_rotation);


        float xRot = Input.GetAxisRaw("Mouse Y");
        Vector3 _cameraRotation = new Vector3(xRot, 0f, 0f) * LookSensitivity;
        motor.RotateCamera(_cameraRotation);
    }
}