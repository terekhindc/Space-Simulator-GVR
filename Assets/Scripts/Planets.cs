using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour {

    string planetName = "Земля";
    int radius = 6371;
    float rotationSpeed = 0.46f;

    // Use this for initialization
    void Start () {
        transform.rotation = Quaternion.Euler(10, 90, 20);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, rotationSpeed*Time.deltaTime, 0);
	}
}
