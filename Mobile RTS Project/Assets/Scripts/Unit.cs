using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Unit", menuName ="Unit")]
public class Unit : ScriptableObject {

	public new  string name;
	public string description;


	public int health;
	public int energy; // tradeoff: fast movement - strong attacks 
	public float shootingRange;
	public float movementSpeed;

	public int ressourceCost;

}
