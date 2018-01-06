using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

	public LayerMask movementMask;

	Camera cam;
	PlayerMotor motor;

	void Start ()
	{
		cam = Camera.main;
		motor = GetComponent<PlayerMotor> ();
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
			}
		} else if (Input.GetMouseButtonDown (1)) {
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 100)) {
				// check if interactable object
			}
		}
	}
}