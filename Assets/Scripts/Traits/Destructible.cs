using UnityEngine;
using System.Collections;

public class Destructible : EventComponent {

	public int health;

	public Action[] m_DamageActions;

	public void Damage(int damage) {
		health -= damage;

		TriggerActions (m_DamageActions);

		if (health <= 0) {
			TriggerActions();
		}
	}
}
