/**
 * Triggers the Actions attached to this EventComponent
 * when the given Collider attached to this GameObject.
 * detects a collision.
 */
using UnityEngine;
using System.Collections;

public class CollisionEvent : EventComponent {

	/* There are many different kinds of collision events in Unity.
	 * Rather than make a separate script for every type of collision
	 * event, we can just add Actions to the collision events we care 
	 * about, and ignore the rest.
	 * 
	 * There are 3 types of collision: Enter, Stay and Exit. Imagine
	 * throwing a ball at a wall. The instant the ball touches the wall
	 * is the "Enter" phase. Stepping forward in slow-motion, as the
	 * ball presses against the wall, this is the "Stay" phase. Finally,
	 * the instant when the ball bounces off the wall is the "Exit" phase.
	 * 
	 * Colliders in Unity can detect whether a collision is an Enter, Stay
	 * or Exit. Since we already have a list of actions from our superclass,
	 * we only need two more lists, which we will use for Stay and Exit.
	 */
	[SerializeField]	
	private Action[] stayActions;
	[SerializeField]
	private Action[] exitActions;

	// More generic version of TriggerActions()
	void TriggerActions( Action[] actionList ) {
		foreach (Action action in actionList) {
			action.PerformAction();
		}
	}

	// TODO: How are we planning on passing parameters into Actions cleanly?

	void OnCollisionEnter( Collision collision ) {
		TriggerActions( actions );
	}

	void OnCollisionStay( Collision collision ) {
		TriggerActions( stayActions );
	}

	void OnCollisionExit( Collision collision ) {
		TriggerActions( exitActions );
	}

	void OnTriggerEnter( Collider collider ) {
		TriggerActions( actions );
	}

	void OnTriggerStay( Collider collider ) {
		TriggerActions( stayActions );
	}

	void OnTriggerExit( Collider collider ) {
		TriggerActions( exitActions );
	}
}
