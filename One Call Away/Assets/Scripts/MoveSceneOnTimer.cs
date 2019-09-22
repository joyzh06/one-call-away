using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MoveSceneOnTimer : MonoBehaviour {

	[SerializeField] public string nextLevel; 

	private int count = 0; 
	private int MAX_COUNT = 3 * 60; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (count >= MAX_COUNT) {
			SceneManager.LoadScene(nextLevel);
		}
		count++; 
	}

}
