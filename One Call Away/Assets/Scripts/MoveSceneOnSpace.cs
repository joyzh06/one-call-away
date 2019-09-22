using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MoveSceneOnSpace : MonoBehaviour {

	[SerializeField] private string nextLevel; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print("hi");
		if (Input.GetKeyDown(KeyCode.Space)) {
			print("hit");
			SceneManager.LoadScene(nextLevel);
		}
		
	}
}
