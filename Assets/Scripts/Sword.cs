using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
	float stunTime;
	public Sword(float damage, float stunTime)
	{
		this.damage = damage;
		this.stunTime = stunTime;
	}

	public override Weapon Clone()
	{
		return new Sword(damage, stunTime);
	}

	public override void Attack()
	{
		Debug.Log("Slashed to deal " + damage + " damage, enemy stunned for " + stunTime + " seconds");
	}
}
