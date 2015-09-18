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

	public string m_TargetTag = null;

	void OnCollisionEnter( Collision collision ) {
		GameObject other = collision.gameObject;
		if (CheckCollision(other)) {
			TriggerActions( actions, other );
		}
	}

	/** Called by CharacterControllerCollision to handle collision with Character Controllers */
	public void OnCharacterCollisionEnter(GameObject other) {
		if (CheckCollision(other)) {
			TriggerActions( actions, other );
        }
	}

	void OnCollisionStay( Collision collision ) {
		GameObject other = collision.gameObject;
		if (CheckCollision(other)) {
			TriggerActions( stayActions, other );
		}
	}

	void OnCollisionExit( Collision collision ) {
		GameObject other = collision.gameObject;
		if (CheckCollision(other)) {
			TriggerActions( exitActions, other );
		}
	}

	void OnTriggerEnter( Collider collider ) {
		GameObject other = collider.gameObject;
		if (CheckCollision(other)) {
			TriggerActions( actions, other );
		}
	}

	void OnTriggerStay( Collider collider ) {
		GameObject other = collider.gameObject;
		if (CheckCollision(other)) {
			TriggerActions( stayActions, other );
		}
	}

	void OnTriggerExit( Collider collider ) {
		GameObject other = collider.gameObject;
		if (CheckCollision(other)) {
			TriggerActions( exitActions, other );
		}
	}

	private bool CheckCollision(GameObject other) {
		return (m_TargetTag == null || m_TargetTag == "" || m_TargetTag == other.tag);
	}
}
