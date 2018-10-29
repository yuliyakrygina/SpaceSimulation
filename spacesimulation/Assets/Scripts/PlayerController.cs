using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PlayerController : MonoBehaviour {

    public float speed;
    public float LookSensitivity; 

   
    private Rigidbody rb;
    public float velocity;

    void Start()
    {
       
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
       


       
    }
}
