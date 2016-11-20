using UnityEngine;
using System.Collections;

public class ForceJump : MonoBehaviour {
	private bool onGround;
	private float forceJumpChanneled;
	private float minForceJump;
	private float maxForceJumpChannelable;
	private Rigidbody2D rbody;

	// Use this for initialization
	void Start () {
		onGround = true;
		forceJumpChanneled = 0f;
		minForceJump = 2f;
		maxForceJumpChannelable = 10f;
		rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (onGround) {
			if (Input.GetButton("Jump")) {
				if (forceJumpChanneled < maxForceJumpChannelable) {
					forceJumpChanneled += Time.deltaTime * 10f;
				} else {
					forceJumpChanneled = maxForceJumpChannelable;
				}
			}else{
				if(forceJumpChanneled > 0f){
					forceJumpChanneled = forceJumpChanneled + minForceJump;
					rbody.AddForce(Vector2.up * forceJumpChanneled); 
					forceJumpChanneled = 0f;
					onGround = false;
				}
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collide){
		if (collide.gameObject.CompareTag("ground")) {
			onGround = true;
		}
	}
}
