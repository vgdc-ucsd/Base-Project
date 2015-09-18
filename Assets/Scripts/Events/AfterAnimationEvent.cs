using UnityEngine;
using System.Collections;

public class AfterAnimationEvent : EventComponent {

	public Animation m_Player;
	public string m_Anim;

	private bool m_WasPlaying = false;

	// Update is called once per frame
	void Update () {
		if (m_Player.IsPlaying(m_Anim)) {
			m_WasPlaying = true;
        }
		if (m_WasPlaying && !m_Player.IsPlaying(m_Anim)) {
			m_WasPlaying = false;
			TriggerActions();
		}
	}
}
