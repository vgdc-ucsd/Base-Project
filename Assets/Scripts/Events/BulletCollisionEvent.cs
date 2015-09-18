using UnityEngine;
using System.Collections;

/**
 * Instead of detecting a collision between colliders, this shoots a ray and sees if it
 * hits anything.
 * 
 * This is useful for fast moving objects, such as bullets.
 */
//TODO add layer mask
public class BulletCollisionEvent : EventComponent {

	public float m_Distance; //distance to shoot the ray - usually the speed of the object



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast (this.transform.position, this.transform.forward, out hit, m_Distance * Time.deltaTime)) {
			TriggerActions(this.actions, hit.collider.gameObject);
			this.enabled = false;
		}
	}
}
