using System.Collections;
using UnityEngine;

[RequireComponent(typeof(UnitMotor))]
public class UnitAgent : MonoBehaviour {

	public Unit unit;
	public LayerMask movementMask;
	public Interactable focus;

	Camera cam;
	UnitMotor motor;

	void Start () {
		Debug.Log (unit.name + " moves with " + unit.movementSpeed);
		cam = Camera.main;
		motor = GetComponent<UnitMotor> ();
		motor.speed = unit.movementSpeed;
	}
		
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 100, movementMask)) {
				// move player there
				motor.moveToPoint(hit.point);
				// stop focus
				RemoveFocus();
			}
		} else if (Input.GetMouseButtonDown (1)) {
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 100)) {

				Interactable interactable = hit.collider.GetComponent<Interactable> ();
				if (interactable != null) {
					SetFocus (interactable);
				}
			}
		}
	}

	void SetFocus (Interactable newFocus) {
		if (newFocus != focus) {

			if (focus != null) 
				focus.OnDefocused ();

			focus = newFocus;
			motor.FollowTarget (newFocus);
		}

		newFocus.OnFocused(transform);
	}

	void RemoveFocus () {
		focus = null;
		if (focus != null) 
			focus.OnDefocused();

		motor.StopFollowingTarget();
	}
}
