using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collider)
    {

        Character character = collider.GetComponent<Character>();

        if (character)
        {
            SceneManager.LoadScene("LevelEnd");
        }
    }
}

