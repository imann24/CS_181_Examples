using UnityEngine;
using System.Collections;

public class CoroutineSpawning : MonoBehaviour {
	public Transform spawnPoint; //declaring these here enables me to input stuff in inspector
	public Transform spawnObject;
	
	
	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnGameObject ()); //initiates ienumerator function
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator SpawnGameObject(){
		
		yield return new WaitForSeconds(1);	
		Instantiate(spawnObject, spawnPoint.position, spawnPoint.rotation);
		
		
	}
	
}
