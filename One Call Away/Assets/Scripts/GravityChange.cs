using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour {

    private bool gravity1 = false;
    private bool gravity2 = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(gravity1);
		
	}

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "gravity1" && !gravity1)
        {
            gravity1 = true;
            this.GetComponent<Rigidbody2D>().gravityScale = 2.5f;
            Debug.Log("fuck");
        }

        if (collision.gameObject.tag == "gravity2" && !gravity2)
        {
            gravity2 = true;
            this.GetComponent<Rigidbody2D>().gravityScale = 2.8f;
        }
    }
}
