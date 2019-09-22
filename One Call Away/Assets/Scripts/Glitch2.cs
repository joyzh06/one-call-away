using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glitch2 : MonoBehaviour
{

    public GameObject platform;
    public Vector3 newPos;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "glitch2")
        {
            platform.transform.position = newPos;
            platform.transform.Rotate(0, 0, -30, Space.World);
        }
    }
}
