using UnityEngine;
using System.Collections;

public class Break_forBCone : MonoBehaviour {

float limit;

	// Use this for initialization
	void Start () {
		GameObject Scroll = GameObject.Find("MainCamera");
		Cannon script = Scroll.GetComponent<Cannon>();
		script.ScorePoint += 10;
		if(script.BallPoint < 40){
			script.BallPoint += 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}