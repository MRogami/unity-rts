using UnityEngine;

public class Interactable : MonoBehaviour {

	public float radius = 2f;

	bool isFocus = false;
	Transform player;

	bool hasInteracted = false;

	public virtual void Interact() {
		// overwrite to define interaction

		Debug.Log ("Interaction with "+gameObject.name);
		hasInteracted = true;
	}

	void Update () {
		if (isFocus && !hasInteracted) {
			float distance = Vector3.Distance (player.position, transform.position);
			if (distance <= radius) {
				Interact();
			}
		}
	}

	public void OnFocused (Transform playerTransform) {
		isFocus = true;
		player = playerTransform;
		hasInteracted = false;
	}

	public void OnDefocused () {
		isFocus = false;
		player = null;
		hasInteracted = false;
	}



	void OnDrawGizmosSelected () {
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(transform.position, radius);
	}

}
