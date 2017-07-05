using UnityEngine;
using System.Collections;

public class Aestroid : MonoBehaviour {
	public GameObject explosion;
	public int aestroidSpeed;
	public float tumble;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = (transform.right + transform.up) * -1 * aestroidSpeed;
		GetComponent<Rigidbody2D>().angularVelocity = tumble * Random.Range (-1, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Boundary" || other.tag == "Enemy" ) 
		{
			return;
		}
		if (other.tag == "Player") 
		{
			if (Input.GetButton("Fire2")) 
			{
				GameController.score -= 10;

			}
			//gameController.GameOver ();
			else
			{
				GameController.score -= 30;

			}
			Destroy (gameObject);
			Instantiate (explosion, transform.position, transform.rotation);
		}
	}
}
