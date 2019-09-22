using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MoveSceneTimer : MonoBehaviour {

    [SerializeField] public string nextLevel;

    public int count = 60;
    private bool finished = false; 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
        {
            count = count - 1; 
        }
        if (count <= 0)
        {
            SceneManager.LoadScene(nextLevel);
            Debug.Log("yeet");
        } else {
            Debug.Log("yote");
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            finished = true; 
           
        }
    }

}
