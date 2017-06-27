using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	GameObject GameController;
	public static float timer;
	public float timeLimit;
	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//if(GameController.gameOver == false)
			
		timer = timer + Time.deltaTime;
		//GameObject.Find ("Timer").GetComponent<Slider> ().value = timer/timeLimit;
		if (timer > timeLimit) 
		{
			SceneManager.LoadScene (3);
		}
	}
}
