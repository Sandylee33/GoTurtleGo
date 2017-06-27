using UnityEngine;
using System.Collections;

public class MoverEnemyBullet : MonoBehaviour {

	//private Rigidbody2D rb2d; 

	public float enemyBulletsSpeed;
	// Use this for initialization
	void Start () {

		//GetComponent<Rigidbody2D>().velocity = transform.right * enemyBulletsSpeed * -1;
		GetComponent<Rigidbody2D>().velocity = (GameObject.FindWithTag("PlayerPosition").GetComponent<Transform>().position - transform.position)/(GameObject.FindWithTag("PlayerPosition").GetComponent<Transform>().position - transform.position).magnitude * enemyBulletsSpeed ;

	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Boundary" || other.tag == "Heart" || other.tag == "Enemy" ) 
		{
			return;
		} 
		//Destroy(gameObject);
		if (other.tag == "Bullet") 
		{
			Destroy (gameObject);
		}
		if (other.tag == "Player") 
		{
			if (Input.GetButton("Fire2")) 
			{
				GameController.score -= 3;
				//return;
			}
			//gameController.GameOver ();
			else
			{
				GameController.score -= 10;

			}
			Destroy(gameObject);
	    }
		//raycast


}
}
