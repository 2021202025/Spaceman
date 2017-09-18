using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovementController : MonoBehaviour {

	public float enemySpeed;

	Animator enemyAnimator;

	//facing 
	public GameObject enemyGraphic;
	bool canFlip = true;
	bool facingRight = false;
	float flipTime = 5f;
	float nextFlipChance = 0f;

	//attacking
	public float chargeTime;
	float startChargeTime;
	bool charging;
	Rigidbody2D enemyRB;


	// Use this for initialization
	void Start () {
		enemyAnimator = GetComponentInChildren<Animator> ();
		enemyRB = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextFlipChance) {
			if (Random.Range (0, 10) >= 5)
				flipFacing ();
			nextFlipChance = Time.time + flipTime;
		}
	}

	void flipFacing () {
		if (!canFlip)
			return;
		float facingX = enemyGraphic.transform.localScale.x;
		facingX *= -1f;
		enemyGraphic.transform.localScale.x = new Vector3 (facingX, enemyGraphic.transform.localScale.y, enemyGraphic.transform.localScale.z);
		facingRight = ! facingRight;
	}
}	
