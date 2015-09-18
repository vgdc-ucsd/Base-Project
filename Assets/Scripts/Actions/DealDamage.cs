using UnityEngine;
using System.Collections;

public class DealDamage : Action {
	public int m_DamageAmount;

	public override void PerformAction(GameObject other) {
		Destructible target;
		if (other != null && (target = other.GetComponent<Destructible>()) != null) {
			target.Damage (m_DamageAmount);
		}
	}
}
