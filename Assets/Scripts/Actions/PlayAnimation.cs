using UnityEngine;
using System.Collections;

public class PlayAnimation : Action {

	public Animation m_Player;
	public string m_AnimToPlay;

	public override void PerformAction(GameObject notUsed) {
		m_Player.Play (m_AnimToPlay);
	}
}
