using UnityEngine;
using System.Collections;

public class ConditionalAction : Action {

	public Action[] actions;

	public bool ready;

	public override void PerformAction(GameObject other) {
		if (ready) {
			TriggerActions(other);
		}
	}

	public void SetReady(bool newValue) {
		ready = newValue;
	}

	protected void TriggerActions(GameObject other) {
		// For every action in the list, perform the action and proceed
		foreach ( Action action in actions ) {
			if ( action != null )
				action.PerformAction(other);
		}
	}
}
