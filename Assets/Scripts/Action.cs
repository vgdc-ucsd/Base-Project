/**
 * Actions do stuff. You'll probably need them in your
 * game. Need to collect some coins? Create a bullet
 * object? Cast a spell? Trigger an explosion? Actions
 * make things like that possible. Of course, you'll
 * have to drag them onto a GameObject with an EventComponent
 * if you really want to use them!
 * 
 * All Actions (read: classes that derive from this one)
 * have a PerformAction() method, which does whatever you
 * tell it to do. That's it. I'm serious.
 */
using UnityEngine;
using System.Collections;

public class Action : MonoBehaviour {
	virtual public void PerformAction(GameObject other) {
		// This is where the subclasses do things.
	}
}
