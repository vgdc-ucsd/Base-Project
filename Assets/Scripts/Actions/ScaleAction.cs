using UnityEngine;
using System.Collections;

public class ScaleAction : Action {
	public Vector3 m_ScaleAmount;
	public float m_Time;
	
	private Vector3 m_StartScale;
	private Vector3 m_EndScale;
	private float m_CurrentTime = 0;
	
	public override void PerformAction(GameObject notUsed) {
		m_StartScale = this.transform.localScale;
		m_EndScale = Vector3.Scale(m_StartScale,m_ScaleAmount);
		m_CurrentTime = 0;
		this.enabled = true;
	}
	
	void Start() {
		this.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		m_CurrentTime += Time.deltaTime;
		float progress = m_CurrentTime / m_Time;
		if (progress > 1) {
			progress = 1;
			this.enabled = false;
		}
		
		this.transform.localScale = Vector3.Lerp (m_StartScale, m_EndScale, progress);
		
	}
}
