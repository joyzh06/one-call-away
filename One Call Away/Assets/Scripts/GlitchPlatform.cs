using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchPlatform : MonoBehaviour {

    public GameObject platform;
    public Vector3 newPos;
    private int x;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "glitch")
        {
            x = 0;
        }
    }
    


}
