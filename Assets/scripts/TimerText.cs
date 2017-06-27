using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerText : MonoBehaviour {
	public Text timerText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timerText.text = ((int)Timer.timer).ToString();
	}
}
