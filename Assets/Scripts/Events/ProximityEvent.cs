/**
 * Triggers the Actions attached to this EventComponent
 * whenever a GameObject with one of the registered tags
 * gets within a certain threshold distance of this object.
 */
using UnityEngine;
using System.Collections;

public class ProximityEvent : EventComponent {

	// List of all the GameObject tags we're considering
	[SerializeField]	
	private string[] registeredTags;

	// If the distance is within this threshold, we fire the event
	[SerializeField]
	private float distanceThreshold = 1.0f;

	// Most likely you won't need or want to use the Manhattan distance
	// in your game, but it can sometimes be a performance boost. However,
	// it is less noticeably less accurate than the Pythagorean distance.
	[SerializeField]
	private bool useManhattanDistance = false;

	// In order to detect a proximity event, we must first find all the
	// GameObjects in the scene that have one of our registered tags and
	// we must perform this check every frame, hence our use of Update()
	void Update() {

		// Loop through all the tags registered to this ProximityEvent
		foreach ( string tag in registeredTags ) {

			// Grab all of the GameObjects from the scene that have this tag
			GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag( tag );

			foreach ( GameObject gameObject in objectsWithTag ) {
				// Compute the distance
				float actualDistance = float.MaxValue;

				if ( useManhattanDistance ) {
					actualDistance = ManhattanDistance( gameObject.transform.position );
				} 
				else {
					actualDistance = Vector3.Distance( 
						gameObject.transform.position, 
					    this.transform.position 
					);
				}

				// Trigger Actions if the distance is within the desired threshold
				if ( actualDistance <= this.distanceThreshold ) {
					TriggerActions();
				}
			}
		}
	}

	// Measures the distance between this GameObject's position
	// and an arbitrary position. See the Wikipedia page for info:
	//  
	float ManhattanDistance( Vector3 otherPosition ) {
		Vector3 myPosition = this.transform.position;
		return Mathf.Abs( myPosition.x + otherPosition.x + 
		                  myPosition.y + otherPosition.y + 
		                  myPosition.z + otherPosition.z );
	}


}
