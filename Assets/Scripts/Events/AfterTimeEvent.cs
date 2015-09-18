using UnityEngine;
using System.Collections;

/**
 * Script for running actions once after a certain time.
 */
public class AfterTimeEvent : EventComponent {

	public float m_TimeDelay=1; //In seconds

	private float m_CurrentTime=0; //how much time has passed so far
	private bool m_Done = false; //whether actions have already been triggered

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		m_CurrentTime += Time.deltaTime;
		if (!m_Done && m_CurrentTime > m_TimeDelay) {
			TriggerActions ();
			m_Done = true;
		}
	}

	public void Reset() {
		m_CurrentTime = 0;
		m_Done = false;
	}
}
