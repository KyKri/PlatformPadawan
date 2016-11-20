using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public int time;
	public Text timer;

	void Start()
	{
		StartCoroutine(countdown());
	}

	IEnumerator countdown()
	{
		while (time > 0)
		{
			yield return new WaitForSeconds(1);

			timer.text = time.ToString();

			time -= 1;
		}

		timer.text = "Out of Time!";
		SceneManager.LoadScene("Failed");
	}



}
