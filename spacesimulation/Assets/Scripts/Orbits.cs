using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbits : MonoBehaviour {

    public GameObject sun;
    public float speed;
    Vector3 spin = new Vector3(0, 1, 0);


    private void Start()
    {
        
    }

    void playerorbit()
    {
        transform.RotateAround(Vector3.zero, spin, speed * Time.deltaTime);
    }




    void FixedUpdate () {

        playerorbit();
		
	}
}
