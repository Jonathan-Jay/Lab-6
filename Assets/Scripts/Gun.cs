using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
	float range;

	public Gun(float damage, float range) {
		this.damage = damage;
		this.range = range;
	}

    public override Weapon Clone() {
		return new Gun(damage, range);
	}

	public override void Attack()
	{
		Debug.Log("Shot " + range + "m and dealt " + damage + " damage");
	}
}
