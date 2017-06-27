using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	//private Rigidbody2D rb2d; 

	public int speed;
	// Use this for initialization
	void Start () {
		
		GetComponent<Rigidbody2D>().velocity = transform.right * speed;
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Boundary" || other.tag == "Heart") 
		{
			return;
		} 
		Destroy(gameObject);
	}

}
