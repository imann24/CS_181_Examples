using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour {
	public GameController gameController;

	public OreType myType;
	// Use this for initialization
	void Start () {
		if (myType == OreType.Bronze) {
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		} else if (myType == OreType.Silver) {
			gameObject.GetComponent<Renderer>().material.color = Color.white;
		} else if (myType == OreType.Gold) {
			gameObject.GetComponent<Renderer>().material.color = Color.yellow;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnMouseDown () {
		gameController.ProcessDestroyedOre(myType);
		Destroy(gameObject);
	}
}
