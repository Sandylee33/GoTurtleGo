using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.O)) 
		{
			SceneManager.LoadScene (3);
		}
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			SceneManager.LoadScene (2);
		}
		if (Input.GetKeyDown (KeyCode.Q)) 
		{
			SceneManager.LoadScene (0);
		}
	}
}
