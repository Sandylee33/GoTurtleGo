using UnityEngine;
using System.Collections;

public class BackGroundScroll : MonoBehaviour {

	public float backGroundScrollSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time * backGroundScrollSpeed, 0f);
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}
}
