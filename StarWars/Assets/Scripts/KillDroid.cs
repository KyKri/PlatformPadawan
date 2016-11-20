using UnityEngine;
using System.Collections;

public class KillDroid : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D stikeDroid){
		Destroy (gameObject);
	}
}
