using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity1 : MonoBehaviour {

    public GameObject player;
    //private bool gravity = false;
    public float gravityScale = 2.35f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            player.GetComponent<Rigidbody2D>().gravityScale = gravityScale;
            //gravity = true;
        }
    }
}
