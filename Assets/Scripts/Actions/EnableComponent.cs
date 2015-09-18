using UnityEngine;
using System.Collections;

public class EnableComponent : Action {

	public Behaviour m_ComponentToEnable;
	public bool m_NewState;

	public override void PerformAction(GameObject notUsed) {
		m_ComponentToEnable.enabled = m_NewState;
	}
}
