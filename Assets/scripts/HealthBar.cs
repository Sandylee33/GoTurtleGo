using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		HandleBar ();
	}

	 void HandleBar()
	{
		GameObject.Find ("HealthBarSlider").GetComponent<Slider> ().value = GameController.score/100f;
	}
}
