using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnClick_restart : MonoBehaviour {
	private GameObject PauseW;
	private GameObject cannon;

	AudioSource sound1;

	// Use this for initialization
	public void Click () {
		sound1 = gameObject.audio;
		sound1.PlayOneShot(sound1.clip);

		PauseW = GameObject.Find("Pause");
		cannon = GameObject.Find("MainCamera");

		cannon.GetComponent<Scroll>().enabled = true;
		cannon.GetComponent<Cannon>().enabled = true;
		PauseW.GetComponent<Canvas>().enabled = false;

		Time.timeScale = 1;
	}
}