using UnityEngine;
using System.Collections;

public class ConditionActionChange : Action {

	public ConditionalAction m_ActionToChange;
	public bool m_Enable;

	public override void PerformAction(GameObject notUsed) {
		m_ActionToChange.SetReady (m_Enable);
	}
	
}
