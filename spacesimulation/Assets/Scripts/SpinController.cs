using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinController : MonoBehaviour {

    public float SpinSpeed; 

	
	void FixedUpdate () {
        transform.Rotate(0, SpinSpeed, 0);
	}
}
