using UnityEngine;
using System.Collections;

public class Cleaner : MonoBehaviour
{
	void OnTriggerStay (Collider col)
	{
		if (col.gameObject.tag == "Dirty") {
			SpriteRenderer renderer = GetComponent<SpriteRenderer> ();
			renderer.color = new Color (0f, 1f, 0f, 1f);

			if (Input.GetKey ("space")) {
				// Todo: Animation de netoyage
				Destroy (col.gameObject);
			}
		} else {
			SpriteRenderer renderer = GetComponent<SpriteRenderer>();
			renderer.color = new Color(1f, 1f, 1f, 1f);
		}
	}
}