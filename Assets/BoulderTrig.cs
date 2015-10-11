using UnityEngine;
using System.Collections;

public class BoulderTrig : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter(Collider other) {
//		if (other.gameObject.CompareTag("OVRPlayerController")){
//			transform.Find("Boulder").Translate(100, -100, 100);
//		}
//	}
		transform.Find("Boulder").Translate(100, -100, 100);
		}
}
