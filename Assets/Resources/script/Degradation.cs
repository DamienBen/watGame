using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degradation : MonoBehaviour {

	public enum Type{
		vomitter,smoker
	}

	public AudioClip dizzy;
	public AudioClip vomit;

	public GameObject trash;

	private float triggerNumber = 200f;
	private float rate = 0.3f;
	private float currentNumber;
	private bool didDizzy = false;

	// Use this for initialization
	void Start () {
		currentNumber = 0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		currentNumber += rate;

		if (currentNumber >= triggerNumber / 2 && !didDizzy) {
			didDizzy = true;
			// TODO: play dizzy animation
			AudioSource source = GetComponent<AudioSource>();
			source.PlayOneShot (dizzy);
		}

		if (currentNumber >= triggerNumber) {
			// TODO: play vomit animation
			// TODO: GameplayBehavior -> makeNoise
			Instantiate(trash, new Vector3(transform.position.x, 0.1f, transform.position.z), trash.transform.rotation);
			AudioSource source = GetComponent<AudioSource>();
			source.PlayOneShot (vomit);
			currentNumber = 0f;
			triggerNumber = 200f + Random.Range (-50, 50);
			didDizzy = false;
		}
	}

	public void reset () {
		currentNumber = 0f;
		didDizzy = false;
	}
}
