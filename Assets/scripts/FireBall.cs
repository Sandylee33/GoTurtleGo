using UnityEngine;
using System.Collections;

public class FireBall : MonoBehaviour {

	public int fireBallSpeed;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = (transform.right + transform.up) * -1 * fireBallSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Boundary" || other.tag == "Enemy" || other.tag == "Boss") 
		{
			return;
		}
		if (other.tag == "Player") 
		{
			GameController.score -= 50;
		}
	}
}
