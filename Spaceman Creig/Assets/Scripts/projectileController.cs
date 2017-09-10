using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileController : MonoBehaviour {

	public float rocketSpeed;

	Rigidbody2D myRigidBody;

	// Use this for initialization
	void Awake () {
		
		myRigidBody = GetComponent<Rigidbody2D> ();

		if(transform.localRotation.z > 0)
			myRigidBody.AddForce (new Vector2 (-1, 0) * rocketSpeed, ForceMode2D.Impulse);
		else
			myRigidBody.AddForce (new Vector2 (1, 0) * rocketSpeed, ForceMode2D.Impulse);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
