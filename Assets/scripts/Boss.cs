using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {
	public float bossSpeed;

	private float bossNextFire;

	public float bossFireRate;

	public Transform shotSpawnEnemy;

	public GameObject enemyShot;

	public int edge;
	// Use this for initialization
	void Start () {
		//enemySpeed = Random.Range (10f, 30f);
		GetComponent<Rigidbody2D>().velocity = transform.up * bossSpeed;

		//GetComponent<Rigidbody2D> ().velocity = transform.up * verticalSpeed;
	}

	// Update is called once per frame
	void Update () {
		if (Time.time > bossNextFire )
		{
			bossNextFire = Time.time + bossFireRate;
			Instantiate(enemyShot, shotSpawnEnemy.position, shotSpawnEnemy.rotation);
		}
		if (this.transform.position.y >= edge) 
		{
			GetComponent<Rigidbody2D> ().velocity = transform.up * -1 * bossSpeed;
		} 
		else if (this.transform.position.y <= -1 * edge) 
		{
			GetComponent<Rigidbody2D> ().velocity = transform.up * bossSpeed;
		}
		if (BossHealth.bossHealth < 25) 
		{
			bossFireRate = 0.6f;
			bossSpeed = 8;
		} 

	}

	// Use this for initialization
	
	// Update is called once per frame

}
