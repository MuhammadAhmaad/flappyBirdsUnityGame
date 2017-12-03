using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour {
	public GameObject Circle;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = this.transform.position;
		position.x = Circle.transform.position.x;
		this.transform.position = position;
	}
}

