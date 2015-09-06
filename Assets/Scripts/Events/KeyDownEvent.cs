/**
 * Triggers the Actions attached to this EventComponent
 * when ANY of the registered keys are pressed, initially.
 * The event will not fire again on the same key until that
 * key is released.
 */
using UnityEngine;
using System.Collections;

public class KeyDownEvent : EventComponent {

	// If any of the keys in this list are pressed during the frame, we
	// will perform the actions associated with this EventComponent
	[SerializeField]
	private KeyCode[] registeredKeys;

	// Update is called once per frame
	void Update () {
		// We don't want to trigger our actions more than once per frame
		bool eventTriggered = false;

		// Loop through all of our registered key codes, if one is pressed,
		// trigger our actions, if we haven't already this frame.
		foreach ( KeyCode keycode in registeredKeys ) {
			if ( Input.GetKeyDown( keycode ) ) {
				if ( !eventTriggered ) {
					TriggerActions();
					eventTriggered = true;
				}
			}
		}
	}
}
