using UnityEngine;
using System.Collections;

public class MoverEnemy : MonoBehaviour {
	public float enemySpeed;

	private float enemyNextFire;

	public float enemyFireRate;

	public Transform shotSpawnEnemy;

	public GameObject enemyShot;

	public int shooting;


	// Use this for initialization
	void Start () {
		//enemySpeed = Random.Range (10f, 30f);
		GetComponent<Rigidbody2D>().velocity = transform.right * -1 * enemySpeed;


	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown (KeyCode.N)) 
//		{
//			shooting = 0;
//		} 
//		else if (Input.GetKeyDown (KeyCode.S)) 
//		{
//			shooting = 1;
//		}
		if (Time.time > enemyNextFire && shooting == 1)
		{
			enemyNextFire = Time.time + enemyFireRate;
			Instantiate(enemyShot, shotSpawnEnemy.position, shotSpawnEnemy.rotation);
		}
	
	}
}
