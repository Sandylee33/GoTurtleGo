using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour {
	[SerializeField]
	public static int bossHealth;

//	public int bossHealthMax;
	// Use this for initialization
	void Start () {
		bossHealth = 35;
	}
	
	// Update is called once per frame
	void Update () {
		if (bossHealth <= 0) 
		{
			SceneManager.LoadScene (4);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Bullet")
		{
			bossHealth -= 1;
		}
	}
}
