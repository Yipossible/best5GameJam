using UnityEngine;
using System.Collections;

public class BoatMoveBackward : MonoBehaviour {

	public Rigidbody boat;
	// Use this for initialization
	void Start () {
		boat = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		float pullSpeed = -1f;
		//boat.AddForce(transform.right * pullSpeed);
		boat.velocity = new Vector3 (-1 ,0,0);

}
		

	}




