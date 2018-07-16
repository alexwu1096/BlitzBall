using UnityEngine;
using System.Collections;

public class ThroughPortal : MonoBehaviour {
	
	public GameObject otherPortal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			other.transform.position = otherPortal.transform.position + otherPortal.transform.forward *-3;
			other.GetComponent < Rigidbody > ().velocity = Vector3.zero;
		}
	}


}



