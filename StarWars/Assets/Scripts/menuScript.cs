using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Button playText;
	public Button exitText;
	public Button mainMenu;
	public Button creditsText;
	public Button helpText;

	public void Play (){
		SceneManager.LoadScene ("Level1");
	}

	public void Exit(){
		Application.Quit ();
	}

	public void Menu (){
		SceneManager.LoadScene ("MainScene");
	}

	public void Credits(){
		SceneManager.LoadScene ("Credits");
	}

	public void Help(){
		SceneManager.LoadScene ("Help");
	}
}
