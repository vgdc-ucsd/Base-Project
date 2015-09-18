using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health_Printer : MonoBehaviour {
	public Text healthDisplay;
	Destructible hpContainer;

	// Use this for initialization
	void Start () {
		hpContainer = this.GetComponent<Destructible> ();
	}
	
	// Update is called once per frame
	void Update () {
		healthDisplay.text = "Health: " + hpContainer.health;
	}
}
