using UnityEngine;
using System.Collections;
using System.Collections.Generic; //NEED THIS LINE TO MAKE ARRAYS

public class FishGod : MonoBehaviour {
	public Fish fishBlueprint;
	public Fish fishBlueprint2;
	public int fishCount = 50;
	
	//array
	public List<Fish> fishList= new List<Fish>();
	
	// Use this for initialization
	void Start () {
		int currentFishcounter = 0;
		while (currentFishcounter < fishCount){
			//Spawn a fish
			Vector3 fishPosition = new Vector3(Random.Range (-10f,10f), Random.Range(-10f, 10f), Random.Range (-10f, 10f) );
			
			//will instantiate blueprint, at this position, with no rotation
			// makes variables. Need to do "as Fish" to cast this OBJECT as a FISH. because instantiate = type Object
			float random = Random.Range (0f, 10f);
			if (random > 5f){
			Fish newFish = Instantiate (fishBlueprint, fishPosition, Quaternion.identity) as Fish;
			fishList.Add (newFish);
			
			}
			
			else {
				Fish newFish = Instantiate (fishBlueprint2, fishPosition, Quaternion.identity) as Fish;
				fishList.Add (newFish);
				
			}
			
			//adds fish to a list! woot!
			
			
			currentFishcounter ++;
		}
	
			
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Space) )
			//for loop. EASIER IN C++ YAY!
			
			//inventing temporary variable = currentFish
			foreach (Fish currentFish in fishList) {
			currentFish.destination = Vector3.zero;
		}
	}
}
