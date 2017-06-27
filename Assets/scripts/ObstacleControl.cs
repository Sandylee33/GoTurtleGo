using UnityEngine;
using System.Collections;

public class ObstacleControl : MonoBehaviour {

	public GameObject fireBall;
	public Vector3 spawnValue_fb;
	public int hazardCount_fb;
	public float spawnWait_fb;
	public float startWait_fb;
	public float waveWait_fb;

	public GameObject asteriod;
	public Vector3 spawnValue_as;
	public int hazardCount_as;
	public float spawnWait_as;
	public float startWait_as;
	public float waveWait_as;

	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnWaves_fb ());
		StartCoroutine(SpawnWaves_As ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator SpawnWaves_fb ()
	{
		yield return new WaitForSeconds (startWait_fb);
		while (true) {
			for (int i = 0; i < hazardCount_fb; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValue_fb.x, spawnValue_fb.x + 5), spawnValue_fb.y, spawnValue_fb.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (fireBall, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait_fb);
			}
			yield return new WaitForSeconds (waveWait_fb);
		}
	}
	IEnumerator SpawnWaves_As ()
	{
		yield return new WaitForSeconds (startWait_as);
		while (true) {
			for (int i = 0; i < hazardCount_as; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValue_fb.x,spawnValue_fb.x + 5), spawnValue_fb.y, spawnValue_fb.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (asteriod, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait_as);
			}
			yield return new WaitForSeconds (waveWait_as);
		}
	}
}
