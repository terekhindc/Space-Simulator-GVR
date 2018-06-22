using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Spaceship : MonoBehaviour {
    
    float speed;
    public GameObject vrCamera;
    Vector3 forward;

    // Use this for initialization
    void Start () {        
        speed = 20;
	}
	
	// Update is called once per frame
	void Update () {        
        forward = vrCamera.transform.forward * speed * Time.deltaTime;
        transform.Translate(forward);
    }
}
