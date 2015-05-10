using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnClick_title : MonoBehaviour {
	private	GameObject score;

	// Use this for initialization
	public void Click () {
		score = GameObject.Find("Score");
		score.GetComponent<Canvas>().enabled = false;
	}
}