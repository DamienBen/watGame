using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionValue : MonoBehaviour {

	public float currentValue;
	public float triggerValue;
	public float rate = 0.25f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (currentValue <= 100f)
			currentValue += rate;
	}

	public void releaseTension () {
		triggerValue = 0;
	}
}
