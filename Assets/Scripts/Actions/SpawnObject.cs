using UnityEngine;
using System.Collections;

public class SpawnObject : Action {

	public Transform[] m_SpawnedObjects;
	//TODO add this? > public bool m_RandomPickMode=false; //enable to randomly spawn one of the objects, instead of all of them.

	//public Vector3 m_SpawnOffset;

	public Transform m_SpawnLocation;
	
	public override void PerformAction(GameObject notUsed) {
		foreach (Transform newObj in m_SpawnedObjects) {
			Instantiate(newObj, m_SpawnLocation.position, this.transform.rotation);
		}	
	}
}
