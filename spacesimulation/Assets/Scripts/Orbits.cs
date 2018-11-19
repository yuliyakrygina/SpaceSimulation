using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbits : MonoBehaviour {

    public GameObject sun;
    public float speed; 

	void FixedUpdate () {

        transform.RotateAround(Vector3.zero, new Vector3(0, 1, 0), speed * Time.deltaTime);
		
	}
}
