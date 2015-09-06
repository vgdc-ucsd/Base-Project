/**
 * EventComponents can go by many names: listeners, detectors,
 * triggers, etc. If you would like a GameObject to perform an
 * action (i.e. walk forward or shoot) when say, the player presses
 * a certain key, you will need to register that Action with a
 * corresponding EventComponent.
 * 
 * This class defines the basic structure of an EventComponent.
 * All EventComponents have a list of actions, which are performed
 * whenever the event in question occurs. 
 * 
 * Example:
 * An EventComponent that waits for key presses would call TriggerActions() 
 * whenever it detects a key press in Update().
 */
using UnityEngine;
using System.Collections;

public class EventComponent : MonoBehaviour {

	/**
	 * Sometimes you want to perform multiple actions when a single
	 * event fires. From the Unity editor, you can drag Action scripts
	 * onto this EventComponent's action list. They will be performed
	 * in order every time an event occurs. The [SerializeField] allows
	 * Unity to make this variable visible in the editor (it would be 
	 * hidden otherwise because it is not public.)
	 */
	[SerializeField]
	protected Action[] actions;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/**
	 * Call this from Update() whenever an event is fired. All of the
	 * Actions associated with this EventComponent will be performed.
	 */
	// TODO: Maybe call this PerformActions?
	protected void TriggerActions() {
		// For every action in the list, perform the action and proceed
		foreach ( Action action in this.actions ) {
			if ( action != null )
				action.PerformAction();
		}
	}

}