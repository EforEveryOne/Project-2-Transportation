using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MainScript : MonoBehaviour {
// Varriables are defined here.
    public static GameObject currentCube;
	public static GameObject redCube;
	int xPosition;
	Vector3 cubePosition;
	GameObject[]cubeRow = new GameObject [16];
	public GameObject cubePrefab;
// This is where things start to happen.
	void Start () {
// Spacing between the cubes.		
		xPosition = 2;
		// Tells the cubes where to be and when to be (right away).
		cubePosition = new Vector3 (-15, 0, 0);
		for (int i = 0; i < 16; i++) {
			cubeRow[i] = (GameObject)Instantiate (cubePrefab, cubePosition, Quaternion.identity);
			cubePosition += new Vector3 (xPosition, 0, 2);
// Makes the cubes white.
			cubeRow[i].GetComponent<Renderer> ().material.color = Color.white;
		}
	}
// Where things may happen in the future of this project.
	void Update () {
	}
}