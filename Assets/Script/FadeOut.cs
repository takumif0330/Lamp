using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.FadeTo(gameObject, iTween.Hash("alpha", 0, "time", 1f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
