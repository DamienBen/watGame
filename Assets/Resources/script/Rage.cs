using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rage : MonoBehaviour {

	private float tension;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (tension <= 100f)
			tension += 0.25f;

		if (tension >= 50f) {
			SpriteRenderer renderer = GetComponent<SpriteRenderer> ();
			renderer.color = new Color (1f, 0f, 0f, 1f); // Set to red	
		} else {
			SpriteRenderer renderer = GetComponent<SpriteRenderer> ();
			renderer.color = new Color (1f, 1f, 1f, 1f); // Set to white
		}
	}

	public void releaseTension () {
		Debug.Log("NOW");
		tension = 0;
	}
}
