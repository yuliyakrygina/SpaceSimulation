using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

    private CharacterController controller;
    private Vector3 movement = Vector3.zero;

    public float speed; 


	void Start () {

        controller = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (controller.isGrounded)
        {
            movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            movement = transform.TransformDirection(movement) * Time.fixedDeltaTime;  
            movement = movement * speed;


        }

        controller.Move(movement * Time.fixedDeltaTime);

	}
}
