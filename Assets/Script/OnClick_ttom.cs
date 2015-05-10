using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnClick_ttom : MonoBehaviour {

AudioSource sound1;

	// Use this for initialization
	public void Click () {
		Time.timeScale = 1;
		sound1 = gameObject.audio;
		sound1.PlayOneShot(sound1.clip);

		Application.LoadLevel("main");
	}
}