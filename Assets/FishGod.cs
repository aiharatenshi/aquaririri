using UnityEngine;
using System.Collections;

public class FishGod : MonoBehaviour {
	public Fish fishBlueprint;
	public int fishCount = 100;
	
	
	// Use this for initialization
	void Start () {
		int currentFishcounter = 0;
		while (currentFishcounter < fishCount){
			//Spawn a fish
			Vector3 fishPosition = new Vector3(Random.Range (-10f,10f), Random.Range(-10f, 10f), Random.Range (-10f, 10f) );
			
			//will instantiate blueprint, at this position, with no rotation
			Instantiate (fishBlueprint, fishPosition, Quaternion.identity);
			
			//increment fishcounter
			currentFishcounter ++;
		}
	
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
