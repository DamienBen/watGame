using UnityEngine;
using System.Collections;

public class TensionReleaser : MonoBehaviour
{
	void OnTriggerStay (Collider col)
	{
		if (col.gameObject.tag == "Tension") {
			SpriteRenderer renderer = GetComponent<SpriteRenderer> ();
			renderer.color = new Color (0f, 1f, 0f, 1f);

			if (Input.GetKey ("space")) {
				Rage rage = col.gameObject.GetComponent<Rage> ();
				rage.releaseTension ();
			}
		}
	}

	void OnTriggerExit(Collider col)
	{
		SpriteRenderer renderer = GetComponent<SpriteRenderer>();
		renderer.color = new Color(1f, 1f, 1f, 1f);
	}
}