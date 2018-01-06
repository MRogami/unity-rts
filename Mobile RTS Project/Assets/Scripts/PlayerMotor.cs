using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour {

	NavMeshAgent agent;

	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}

	public void moveToPoint (Vector3 point) {
		agent.SetDestination (point);	
	}
}
