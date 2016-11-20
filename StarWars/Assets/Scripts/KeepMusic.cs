using UnityEngine;
using System.Collections;

public class KeepMusic : MonoBehaviour {

	private static KeepMusic instance = null;

	public static KeepMusic Instance {
		get { return instance; }
	}

	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} 
		else
		{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	void Update(){
		if ((Application.loadedLevelName == "Finale") || (Application.loadedLevelName == "Failed") || (Application.loadedLevelName == "Help") || (Application.loadedLevelName == "Credits")) {
			if(this.gameObject == instance.gameObject)
				Destroy (this.gameObject);
		}
	}

}