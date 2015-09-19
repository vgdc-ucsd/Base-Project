using UnityEngine;
using System.Collections;

public class QuickChaseBehaviour : MonoBehaviour {
	public float m_Speed=5;
	public Transform m_Target;
	public Vector3 moveOffset;

	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = this.GetComponent<Rigidbody> ();	
		if (m_Target == null) {
			GameObject[] targetList = GameObject.FindGameObjectsWithTag("Player");
			foreach (GameObject tar in targetList) {
				if (tar.GetComponent<CharacterController>() != null) {
					m_Target = tar.transform;
					break;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetVector = new Vector3(m_Target.position.x, transform.position.y, m_Target.position.z);
		this.transform.LookAt (targetVector, Vector3.up);
		rigidbody.MovePosition (this.transform.position + (transform.forward+moveOffset) * (m_Speed * Time.deltaTime));
	}
}
