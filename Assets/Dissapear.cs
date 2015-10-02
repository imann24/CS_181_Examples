using UnityEngine;
using System.Collections;

public class Dissapear : MonoBehaviour {

	GameObject thisGameObject;

	// Use this for initialization
	void Start () {
		// This will hide it
		gameObject.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {

		Destroy (gameObject);
	}




}
