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

            rb.velocity = -transform.right * speed * Time.fixedDeltaTime;  // rigidbody.velocity = transform.up * speed * Time.DeltaTime

        }
        if (Input.GetKey(KeyCode.DownArrow)){

            rb.velocity = transform.right * speed * Time.fixedDeltaTime; // rigidbody.velocity = -transformup * speed * Time.DeltaTime

        }
        if (Input.GetKey(KeyCode.LeftArrow)) //vector3 needed because it is rotating, its not moving its rotating
        {
            transform.Rotate(new Vector3(0, 1, 0) * velocity * Time.fixedDeltaTime, Space.World); //transform.Rotate(new Vector3(0,0,1) * velocity * Time.DeltaTime, Space.World)
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0) * velocity * Time.fixedDeltaTime, Space.World);

        }
        if (Input.GetKey(KeyCode.Space)) //figure out 
        {

            rb.velocity = new Vector3(-1, 0, 0) * speed * Time.fixedDeltaTime;
        }
       


        /*
         *  camera, mouse work
         */
        /*
        //playerrotation, didnt want camera to move as fast as speed or velocity, new float. 
        //float yRot = Input.GetAxisRaw("Mouse X"); 
        Vector3 _rotation = new Vector3(0f, Input.GetAxisRaw("Mouse X"), 0f) * LookSensitivity;  // change 
        motor.Rotate(_rotation);
        
        
        //camerarotation 
        //float xRot = Input.GetAxisRaw("Mouse Y");
        Vector3 _cameraRotation = new Vector3(Input.GetAxisRaw("Mouse Y"), 0f, 0f) * LookSensitivity; //change 
        motor.RotateCamera(_cameraRotation);
        */
    }
}
