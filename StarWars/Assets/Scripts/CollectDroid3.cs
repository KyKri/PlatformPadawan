using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CollectDroid3 : MonoBehaviour{
	// Tally Counter
	private int tally;

	public Text count;

	public int droids;


	void Start(){
		tally = 0;
		UpdateCounter();
	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.gameObject.CompareTag("droid")){
			tally += 1;
			UpdateCounter();
			if (tally == droids){
				SceneManager.LoadScene("Finale");
			}
		}
	}

	void UpdateCounter(){
		count.text = "Droids: " + tally.ToString();
	}

}