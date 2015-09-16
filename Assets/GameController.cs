using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// This is a public reference to the Cube GameObject
	public GameObject Cube;

	//this is a value to represent whether a cube has been spawned
	bool cubeSpawned = false;


	// Use this for initialization
	void Start () {
	
	}

	// Runs every single frame
	void Update () {
		// Checks whether it is time to spawn the cube
		if (TimeToSpawnCube()) {
			// Spawns a cube if the check returns true
			SpawnCube ();
		}
	}

	// Used to spawn a cube into the game world
	void SpawnCube () {
		// Creates a position at the origin of the game world
		Vector3 cubePosition = new Vector3(0.0f, 0.0f, 0.0f);
		
		// Spawns a cube object at the specified position with no rotation
		Instantiate(Cube, cubePosition, Quaternion.identity);
		
		// Sets the bool to true so that only one cube spawns
		cubeSpawned = true;
	}

	// Checks whether it is the proper time to spawn the cube
	bool TimeToSpawnCube () {
		// Checks whether the game has passed the three second mark and whether a cube has not already been spawned
		if (Time.time >= 3.0f && !cubeSpawned) {
			// returns a value of true if the conditions are met
			return true;
		} else {
			// returns a value of false if the conditions are not met
			return false;
		}
	}

}
