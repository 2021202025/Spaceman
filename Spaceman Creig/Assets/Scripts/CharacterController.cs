using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

	// movement variables
	public float maxSpeed;

	private Rigidbody2D myRigidBody;
	private Animator myAnimator;

	private bool facingRight;



	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
		myAnimator = GetComponent<Animator> ();

		facingRight = true;

	}
	
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		myAnimator.SetFloat ("Speed", Mathf.Abs(move));

		myRigidBody.velocity = new Vector2 (move * maxSpeed, myRigidBody.velocity.y);

		if (move > 0 && !facingRight) {
			flip ();
		} 

		else if (move < 0 && facingRight) {
			flip ();
		}
		
	}

	void flip () {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1; 
		transform.localScale = theScale;
	}
}
