using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MoveSceneOnTimer : MonoBehaviour {

	[SerializeField] public string nextLevel; 

	private int count = 0; 
	public float MAX_COUNT; 

	// Use this for initialization
	void Start () {
		MAX_COUNT *= 60; 
	}
	
	// Update is called once per frame
	void Update () {
		if (count >= MAX_COUNT) {
			SceneManager.LoadScene(nextLevel);
		}
		count++; 
	}

}
