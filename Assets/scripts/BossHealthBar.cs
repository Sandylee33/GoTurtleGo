using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour {

	public int bossHealthSpeed;

	public int edge;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = transform.right * bossHealthSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y >= edge) 
		{
			GetComponent<Rigidbody2D> ().velocity = transform.right * -1 * bossHealthSpeed;
		} 
		else if (this.transform.position.y <= -1 * edge) 
		{
			GetComponent<Rigidbody2D> ().velocity = transform.right * bossHealthSpeed;
		}
		GameObject.FindWithTag ("BossHealth").GetComponent<Slider> ().value = BossHealth.bossHealth/35f;

		if (BossHealth.bossHealth < 25) 
		{
			
			bossHealthSpeed = 0;
		} 

	}
}
