using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        if (gameObject.name == "Exit")
        {

            Application.Quit();

        }

        if (gameObject.name == "Restart")
        {
            

            SceneManager.LoadScene("Level");

            
        }

        if (gameObject.name == "Play")
        {
            
            SceneManager.LoadScene("Level");
            
        }
    }
}
