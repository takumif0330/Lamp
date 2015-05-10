using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnClick_Pause : MonoBehaviour {
	private GameObject PauseW;
	private	GameObject cannon;

	// Use this for initialization
	public void Click () {
		StartCoroutine("Call");
	}

	IEnumerator Call(){
		PauseW = GameObject.Find("Pause");
		cannon = GameObject.Find("MainCamera");

		yield return new WaitForSeconds(0.1f);

		Time.timeScale = 0;
		PauseW.GetComponent<Canvas>().enabled = true;
		cannon.GetComponent<Scroll>().enabled = false;
		cannon.GetComponent<Cannon>().enabled = false;		
	}
}