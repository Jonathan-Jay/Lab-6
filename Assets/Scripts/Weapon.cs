using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
	public float damage;
	
	public abstract Weapon Clone();

	public abstract void Attack();
}
