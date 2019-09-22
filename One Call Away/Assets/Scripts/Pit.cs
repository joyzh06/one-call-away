using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pit : MonoBehaviour {
    public GameObject player;
    private Vector3 start;
    private float startGrav;

	// Use this for initialization
	void Start () {
        start = player.transform.position;
        startGrav = player.GetComponent<Rigidbody2D>().gravityScale;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            player.transform.position = start;
            player.GetComponent<Rigidbody2D>().gravityScale = startGrav;
        }
    }
}
