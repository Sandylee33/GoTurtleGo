using UnityEngine;
using System.Collections;

public class Deflecting : MonoBehaviour {

	public GameObject deflectShot;

	public Transform shotSpawn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "EnemyBullet" && Input.GetButton("Fire2")) 
		{
			Instantiate (deflectShot, shotSpawn.position, shotSpawn.rotation);
		}
	}
}
