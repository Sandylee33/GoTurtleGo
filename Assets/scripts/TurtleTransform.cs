using UnityEngine;
using System.Collections;

public class TurtleTransform : MonoBehaviour {

	private Rigidbody2D rb2d;
	public int transformSpeed;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetButton ("Fire2")) 
		{
			transformSpeed = 4;
		} 
		else 
		{
			transformSpeed = 10;
		}
		float moveHorizontal = Input.GetAxis ("Horizontal");


		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.velocity = movement * transformSpeed;
		rb2d.position = new Vector2 (Mathf.Clamp (rb2d.position.x, -12, 12), Mathf.Clamp (rb2d.position.y, -6, 6));
	}
}
