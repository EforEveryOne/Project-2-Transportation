using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class CubeBehavior : MonoBehaviour {
	public GameObject cubePrefab;
// When the mouse clickes down on the object, the things below will happen.
	void OnMouseDown () {
// if the red cube is false it'll turn white		
		if (MainScript.redCube != null) {
			MainScript.redCube.GetComponent<Renderer> ().material.color = Color.white;
		}
// Turns the clicked cube red and assigns it the redcube
		gameObject.GetComponent<Renderer> ().material.color = Color.red;
		MainScript.redCube = gameObject;
	}
}