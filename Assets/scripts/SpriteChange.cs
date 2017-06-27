using UnityEngine;
using System.Collections;

public class SpriteChange : MonoBehaviour {

	public Sprite blueGuy;

	public Sprite redGuy;

	private Sprite a;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire2")) 
		{
			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == blueGuy) 
			{
				ChageSprite (redGuy);
			} 
		
		} 
		else 
		{
			ChageSprite(blueGuy);
		}

	}
	void ChageSprite(Sprite a)
	{
		this.gameObject.GetComponent<SpriteRenderer> ().sprite = a;
	}
}
