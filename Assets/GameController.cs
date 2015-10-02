using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	//tuning variables
	public float spawnTime = 3.0f;
	public int bronzePoints = 1, silverPoints = 10, goldPoints = 100;

	public GameObject bronzeCubePrefab;
	public GameObject silverCubePrefab;
	public GameObject goldCubePrefab;

	private int bronzeCount = 0, silverCount = 0, goldCount = 0;
	
	private int score = 0;
	private float timeToAct;

	// Use this for initialization
	void Start () {
		timeToAct = spawnTime;
	}
	
	// Update is called once per frame
	void Update () {

		// This check determines when we spawn a new cube
		if (Time.time >= timeToAct) {
			timeToAct += spawnTime;

			// Creates a reference to the cube we're about to spawn
			GameObject cubePrefab = null;


			// if we're spawning a gold count
			if (silverCount == 2 && bronzeCount == 2) {
				cubePrefab =  (GameObject) Instantiate(goldCubePrefab, 
				            new Vector3(Random.Range(-9f, 9f), Random.Range(-3f, 5f), 0),
				            Quaternion.identity);
				goldCount++;
			} 


			// if we're spawning a silver cube
			else if (bronzeCount >= 4) {
				cubePrefab =  (GameObject) Instantiate(silverCubePrefab, 
                           new Vector3(Random.Range(-9f, 9f), Random.Range(-3f, 5f), 0),
                           Quaternion.identity);
				silverCount++;
			} 

			// if we're spawning a bronze cube
			else {
				cubePrefab =  (GameObject) Instantiate(bronzeCubePrefab, 
                           new Vector3(Random.Range(-9f, 9f), Random.Range(-3f, 5f), 0),
                           Quaternion.identity);
				bronzeCount++;
			}

			// gives the cube's CubeBehavior script a reference to the GameController so it can call the ProcessDestroyedOre method
			cubePrefab.GetComponent<CubeBehavior>().gameController = this;
		}
	}

	public void ProcessDestroyedOre (OreType oreType) {
		if (oreType == OreType.Bronze) {
			bronzeCount--;
			score += bronzePoints;
		} else if (oreType == OreType.Silver) {
			silverCount--;
			score += silverPoints;
		} else if (oreType == OreType.Gold) {
			goldCount--;
			score += goldPoints;
		}
	}
}
