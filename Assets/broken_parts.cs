using UnityEngine;
using System.Collections;

public class broken_parts : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float r = Random.value;
		float m = Random.value;
		float l;

		if(m <= 0.5){
			l = -1;
		}
		else{
			l = 1;
		}
		transform.localScale = new Vector3(Random.Range(0.5f, 1.5f),Random.Range(0.5f, 1f),Random.Range(0.5f, 1.5f));
		transform.rigidbody.AddForce(r * l ,1.5f * r, 1.5f * r, ForceMode.Impulse);
				}
	
	// Update is called once per frame
	void Update () {
	
	}
}
