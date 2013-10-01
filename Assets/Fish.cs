using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {
	public Vector3 destination = new Vector3 (5f, 5f, 0f);
	public float speed = 5f;
		
	// Use this for initialization
	
	void Start () {
	//will call a function every "x" seconds. (function, how long at start before function launches, how long between each time function executes)
	  InvokeRepeating ("SetNewDestination", 0f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
		//makes it face the direction its swimming in
		
		transform.rotation = Quaternion.LookRotation (rigidbody.velocity);
	
	}
	
	//Update takes place in unguarenteed time between frames. Fixed Update will update on a fixed interval (ex. every 0.02 games)
	void FixedUpdate() {
		//makes fish swim forward
		Vector3 direction = Vector3.Normalize (destination - transform.position);
		
		//awkward zooming of fish to get to its destination	
		//rigidbody.AddForce( destination - transform.position );
		//rigidbody.AddForce(destination);
		rigidbody.AddForce (direction *speed, ForceMode.VelocityChange);
}
	void SetNewDestination(){
		//set a random destination
		
		//this generates random vector 3 numbers within a sphere with the radius = 1. 
		//If we times it by 100, the sphere will now have r=100
		destination = Random.insideUnitSphere *50f;
	}
		
} 
