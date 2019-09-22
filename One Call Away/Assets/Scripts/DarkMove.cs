using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkMove : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = player.transform.position + new Vector3(-1.4f, 2.8f, 0);
		
	}
}
