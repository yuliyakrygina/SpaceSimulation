using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerController : MonoBehaviour {

    public float speed;
    public float LookSensitivity;
    //public float velocity;
   
    private Rigidbody rb;
   

    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
  

       
        if (Input.GetKey(KeyCode.UpArrow)){ //doesnt need vector3 because it is just going up or down

            rb.velocity = -transform.right * speed * Time.fixedDeltaTime;  // rigidbody.velocity = transform.up * speed * Time.DeltaTime 

        }
        if (Input.GetKey(KeyCode.DownArrow)){

            rb.velocity = transform.right * speed * Time.fixedDeltaTime; // rigidbody.velocity = -transformup * speed * Time.DeltaTime

        }
        if (Input.GetKey(KeyCode.LeftArrow)) //spinning on y axis 
        {
            transform.Rotate(new Vector3(0, 1, 0) * speed * Time.fixedDeltaTime, Space.World); //transform.Rotate(new Vector3(0,0,1) * velocity * Time.DeltaTime, Space.World)
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0) * speed * Time.fixedDeltaTime, Space.World); //Move the object upward in world space 1 unit/second.

        }
        if (Input.GetKey(KeyCode.Space)) //figure out 
        {

            rb.velocity = new Vector3(-1, 0, 0) * speed * Time.fixedDeltaTime;
        }
       


       
    }
}
