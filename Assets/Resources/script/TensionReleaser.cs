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
				Degradation degradation = col.gameObject.GetComponent<Degradation> ();
				degradation.reset ();
			}
		}
	}

	void OnTriggerExit(Collider col)
	{
		SpriteRenderer renderer = GetComponent<SpriteRenderer>();
		renderer.color = new Color(1f, 1f, 1f, 1f);
	}
}