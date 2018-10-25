using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(PlayerMotor))]

public class PlayerController : MonoBehaviour {

    public float speed;
    public float LookSensitivity; 

    private PlayerMotor motor;
    private Rigidbody rb;
    public float velocity;

    void Start()
    {
        motor = GetComponent<PlayerMotor>(); //fetch playmotor from game object
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

       
        if (Input.GetKey(KeyCode.UpArrow)){ //doesnt need vector3 because it is just going up or down

            rb.velocity = transform.up * speed * Time.fixedDeltaTime;

        }
        if (Input.GetKey(KeyCode.DownArrow)){

            rb.velocity = -transform.up * speed * Time.fixedDeltaTime;

        }
        if (Input.GetKey(KeyCode.LeftArrow)) //vector3 needed because it is rotating
        {
            transform.Rotate(new Vector3(0, 0, 1) * velocity * Time.fixedDeltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -1) * velocity * Time.fixedDeltaTime, Space.World);

        }
        if (Input.GetKey(KeyCode.Space)) //figure out 
        {

            rb.velocity = new Vector3(-1, 0, 0) * speed * Time.fixedDeltaTime;
        }
       



        
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
