using UnityEngine;
using System.Collections;


public class PlayerContorller : MonoBehaviour {
	
	public float speed;             
	private Rigidbody2D rb2d;       
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;
	private GameController gameController;
	public int speedSlow, speedFast;
	private AudioSource audioSource;

	void Start()
	{
		gameController = GameObject.Find("GameController").GetComponent<GameController> ();
		rb2d = GetComponent<Rigidbody2D> ();
		audioSource = GetComponent<AudioSource>();
	}

	void Update()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire && !Input.GetButton("Fire2"))
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			audioSource.Play ();
		}
		if (GameController.score <= 0) 
		{
			Destroy (gameObject);
			gameController.GameOver ();
		}
	}

	void FixedUpdate()
	{
		if (Input.GetButton ("Fire2")) 
		{
			speed = speedSlow;
		} 
		else 
		{
			speed = speedFast;
		}

		float moveHorizontal = Input.GetAxis ("Horizontal");


		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.velocity = movement * speed;
		rb2d.position = new Vector2 (Mathf.Clamp (rb2d.position.x, -12, 12), Mathf.Clamp (rb2d.position.y, -6, 6));

	}
}
