using UnityEngine;
using System.Collections;

public class CharacterControllerCollision : MonoBehaviour {

	public void OnControllerColliderHit( ControllerColliderHit hit) {
		CollisionEvent otherEvent;
		if ((otherEvent = hit.gameObject.GetComponent<CollisionEvent>()) != null) {
			otherEvent.OnCharacterCollisionEnter(this.gameObject);
		}
	}

}
