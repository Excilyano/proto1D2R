using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CineTrigger : MonoBehaviour {
	public string message;

	public void OnTriggerEnter(Collider coll) {
		TextManagement.UpdateText(message);
	}

	public void OnTriggerExit(Collider coll) {
		TextManagement.UpdateText("");
	}
}
