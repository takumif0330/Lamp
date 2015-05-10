using UnityEngine;
using System.Collections;

public class ScoreOpen : MonoBehaviour {

private GameObject NSGO;

	// Use this for initialization
	void Start () {
		GameObject nowscore = GameObject.Find("HighScore_Text");
		TitleText script = nowscore.GetComponent<TitleText>();
		if(script.NowScore > 0){
			NSGO = GameObject.Find("Score");
			NSGO.GetComponent<Canvas>().enabled = true;
		}
	}

	// Update is called once per frame
	void Update () {
		if( PlayerPrefs.HasKey("nowscore")){
		PlayerPrefs.DeleteKey("nowscore");
		}
	}
}