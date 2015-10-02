using UnityEngine;
using System.Collections;

public class SpawnCube : MonoBehaviour {
	public GameObject cube;
	bool cubeHasSpawned = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > 3 && cubeHasSpawned == false){ //Time has passed
			Instantiate(cube, new Vector3(0,0,0), Quaternion.identity);//Spawn cube
			cubeHasSpawned = true;
		}
	}
}



//SPAWN A CUBE
//AFTER CERTAIN TIME
//STOP SPAWNING CUBES