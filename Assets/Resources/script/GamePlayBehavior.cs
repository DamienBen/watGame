using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayBehavior : MonoBehaviour {

	public float brothel = 100;
	public float maxBrothel = 100;
	public  UnityEngine.UI.Image currentBH;

	public void TakeDamage(float damage) {
		brothel -= damage;
		float ratio = brothel / maxBrothel;
		currentBH.rectTransform.localScale = new Vector3 (ratio, 1, 1);
	}

	void Update () {
		TakeDamage(0.1f);
	}
}
