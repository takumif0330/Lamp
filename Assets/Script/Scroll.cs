using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

public float distance_f = 0;
public int distance = 0;

	float i = 0;
	float l = 160;
	float limit;
	GameObject scroll;
	GameObject startpoint;

	bool MissSE;

	public AudioClip sound1;

	void Start(){
		MissSE = true;
		scroll = GameObject.Find("MainCamera");
		iTween.MoveTo(gameObject, new Vector3(0, 1f, -15f), 2.0f);
	}
	// Update is called once per frame
	void Update(){
		Cannon script = scroll.GetComponent<Cannon>();
		limit = script.ScorePoint;

		if(limit > 0){
			if (i<=160){
				transform.Translate(0, 0, i/40 * Time.deltaTime);
				i += 3;
			}
			else{
				transform.Translate(0, 0, 4 * Time.deltaTime);
			}
		}
		else{
			if(l>0){
				if(MissSE){
				audio.PlayOneShot(sound1);
				MissSE = false;
				}
				transform.Translate(0, 0, l/40 * Time.deltaTime);
				l -= 1;
			}
			else{
				startpoint = GameObject.Find("StartPoint");
				distance_f = Vector3.Distance(startpoint.transform.position, transform.position);
				distance = (int)Mathf.Round(distance_f);
				PlayerPrefs.SetInt("nowscore", distance);
				Application.LoadLevel("Title");
			}
		}
	}
}