using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayBehavior : MonoBehaviour {

	public float brothel = 100;
	public float maxBrothel = 100;
	public  UnityEngine.UI.Image currentBH;
	public GameObject[] dudes;
	public static List<GameObject>allDudes = new List<GameObject>();

	public void Start() {
		InvokeRepeating("SpawnDude", 2.0f, 1.0f);
	}

	public void MakeNoise(float damage) {
		brothel -= damage;
		float ratio = brothel / maxBrothel;
		currentBH.rectTransform.localScale = new Vector3 (ratio, 1, 1);
	}

	public void SpawnDude() {
		GameObject randomDude = dudes[Random.Range(0, dudes.Length)];
		GameObject dude = Instantiate (randomDude, randomDude.transform.position, randomDude.transform.rotation);
		allDudes.Add (dude);
	}
		
	void Update () {
		MakeNoise(0.1f);
	}
}
