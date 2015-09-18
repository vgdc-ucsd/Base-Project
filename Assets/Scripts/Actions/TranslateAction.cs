using UnityEngine;
using System.Collections;

public class TranslateAction : Action {
	public Vector3 m_TranslationAmount;
	public float m_Time;

	private Vector3 m_StartPosition;
	private Vector3 m_EndPosition;
	private float m_CurrentTime = 0;

	public override void PerformAction(GameObject notUsed) {
		m_StartPosition = this.transform.localPosition;
		m_EndPosition = m_StartPosition + m_TranslationAmount;
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

		this.transform.localPosition = Vector3.Lerp (m_StartPosition, m_EndPosition, progress);

	}
}
