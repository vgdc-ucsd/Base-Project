using UnityEngine;
using System.Collections;

public class InputEvent : EventComponent {

	public string m_InputEvent;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton (m_InputEvent)) {
			TriggerActions ();
		}
	}
}
