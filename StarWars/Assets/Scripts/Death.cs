using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collide){
		if (collide.gameObject.CompareTag("killFloor")) {
			SceneManager.LoadScene ("Failed");
		}
	}
}
