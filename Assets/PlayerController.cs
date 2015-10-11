using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	Rigidbody player;
	public float speed = 100f;

	void Start () {
		player = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
		player.AddForce(movement*speed);
	}

}
