using UnityEngine;
using System.Collections;

public class Roundtrip : MonoBehaviour {
	float counter = 0f;
	float plus = 0.1f;

	// Update is called once per frame
	void Update () {
		Vector3 p = new Vector3(plus, 0, 0);	
		transform.Translate(p);
		counter++;

		if(counter == 200){
			counter = 0;
			plus *= -1;
		}
	}
}