using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleText : MonoBehaviour {

public int HighScore = 0;
Text HighScoreText;
Text NowScoreText;

public int NowScore = 0;

	// Use this for initialization
	void Start () {
		NowScore = PlayerPrefs.GetInt("nowscore");

		if( PlayerPrefs.HasKey("highscore")){
		HighScore = PlayerPrefs.GetInt("highscore");
		}

		GameObject nowdistance = GameObject.Find("NowDistance");
		NowScoreText = nowdistance.GetComponent<Text>();
		NowScoreText.text = "★" + NowScore;

		if(NowScore > HighScore){
			HighScore = NowScore;
			PlayerPrefs.SetInt("highscore", NowScore);
		}

		HighScoreText = GetComponent<Text>();
		HighScoreText.text = "HighScore：" + HighScore;
	}
	
	// Update is called once per frame
	void Update () {
	}
}