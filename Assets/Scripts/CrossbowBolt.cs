using UnityEngine;
using System.Collections;

public class CrossbowBolt : EventComponent {
	
	public float m_Distance; //distance to shoot the ray - usually the speed of the object
	public float m_HitForce = 40; //force to apply to objects the bolt hits

	private Vector3 m_InitalScale;
	
	// Use this for initialization
	void Start () {
		m_InitalScale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast (this.transform.position, this.transform.forward, out hit, m_Distance * Time.deltaTime)) {
			transform.position += this.transform.forward * hit.distance;
			this.transform.parent = hit.collider.gameObject.transform;

			Vector3 newScale = new Vector3( m_InitalScale.x / this.transform.parent.localScale.x,
											m_InitalScale.y / this.transform.parent.localScale.y,
			                                m_InitalScale.z / this.transform.parent.localScale.z);
			this.transform.localScale = newScale;

			TriggerActions(this.actions, hit.collider.gameObject);

			if (hit.collider.attachedRigidbody != null) {
				hit.collider.attachedRigidbody.AddForceAtPosition(this.transform.forward * m_HitForce, this.transform.position);
			}

			this.enabled = false;
		}
	}
}
