﻿using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	public GameObject heart;
	public GameObject explosion;
	//private GameController gameController;

	void Start()
	{
		//gameController = GameObject.Find("GameController").GetComponent<GameController> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		
		if (other.tag == "Boundary"|| other.tag == "Enemy"|| other.tag == "EnemyBullet") 
		{
			return;
		} 
		if (other.tag == "Bullet") 
		{
			Instantiate (heart, transform.position, transform.rotation);
		}
		Destroy(gameObject);
		Explosion ();
		if (other.tag == "Player") 
		{
			if (Input.GetButton("Fire2")) 
			{
				GameController.score -= 6;
			}
			//gameController.GameOver ();
			else
			{
				GameController.score -= 20;
			}
			Destroy(gameObject);
			Explosion ();
		}
		//Destroy(other.gameObject);

	}
	private void Explosion()
	{
		Instantiate (explosion, transform.position, transform.rotation);
	}
}
