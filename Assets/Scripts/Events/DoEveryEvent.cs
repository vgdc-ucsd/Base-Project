using UnityEngine;
using System.Collections;

/**
 * Script for running actions every time a certain interval of time has passed.
 */
public class DoEveryEvent : EventComponent {
	
	public float m_TimeDelay=1; //In seconds
	
	private float m_CurrentTime=0; //how much time has passed so far
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		m_CurrentTime += Time.deltaTime;
		if (m_CurrentTime > m_TimeDelay) {
			TriggerActions ();
			m_CurrentTime = 0;
		}
	}
}
