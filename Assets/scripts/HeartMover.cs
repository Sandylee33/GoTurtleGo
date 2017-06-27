using UnityEngine;
using System.Collections;

public class HeartMover : MonoBehaviour {
	public int scoreValue;
	private GameController gameController;
	public float heartSpeed;
	// Use this for initialization
	void Start () 
	{
		//heartSpeed = Random.Range (10f, 30f);
		GetComponent<Rigidbody2D>().velocity = transform.right* -1f * heartSpeed;
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) 
		{
			gameController = gameControllerObject.GetComponent<GameController> ();
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag != "Player") {
			return;
		}
		Destroy(gameObject);
		gameController.AddScore (scoreValue);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
