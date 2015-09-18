using UnityEngine;
using System.Collections;

public class Delete : Action {

	public override void PerformAction(GameObject notUsed) {
		Destroy (this.gameObject);
	}
}
