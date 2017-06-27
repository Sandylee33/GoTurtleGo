using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValue;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public float lifeDecrease;
	public int lifeDrain;
	//public float defenseDecrease;

	public Text scoreText;
	public Text restartText;
	public Text gameOverText;
	public static int score ;

	private static bool gameOver;
	private bool restart;
	// Use this for initialization
	void Start () 
	{
		score = 100;
		gameOver = false;
		restart = false;
//		gameOverText.text = "";
	//	restartText.text = "";
		StartCoroutine(SpawnWaves ());
		StartCoroutine (LifeDecrease ());
		UpdateScore ();
	}
	
	// Update is called once per frame
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true) 
		{
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (spawnValue.x, Random.Range (-spawnValue.y, spawnValue.y), spawnValue.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
			if (gameOver) 
			{
				restartText.text = "press 'R' to restart";
				restart = true;
				break;

			}
		}
	}

	public void AddScore(int newScoreValue)
	{
		score += newScoreValue;
		if (score > 100) 
		{
			score = 100;
		}
		UpdateScore ();
	}

	IEnumerator LifeDecrease()
	{
		while (true) 
		{
			yield return new WaitForSeconds (lifeDecrease);
			score -= lifeDrain;
			if(score < 0)
			{
				score = 0;
			}
		}
	}
	void UpdateScore()
	{
//		scoreText.text = "Life:" + score;
	}
	void Update()
	{
//		if (Input.GetButton ("Fire2")) 
//		{
//			score -= defenseDecrease;
//		}
		UpdateScore ();
		if (restart) 
		{
			if (Input.GetKeyDown (KeyCode.R)) 
			{
				SceneManager.LoadScene (2);
			}
		
		}
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			SceneManager.LoadScene (2);
		}
		if (Input.GetKeyDown (KeyCode.O)) 
		{
			SceneManager.LoadScene (3);
		}
//		if (Timer.timer = 30) 
//		{
//			spawnWait -= 0.2;
//			waveWait -= 0.2;
//		}

	}
	public void GameOver ()
	{
		gameOverText.text = "Game Over!";
		gameOver = true;
		SceneManager.LoadScene (5);
	}
}
