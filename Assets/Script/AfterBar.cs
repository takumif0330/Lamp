using UnityEngine;
using System.Collections;

public class AfterBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float r = Random.value;

		transform.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
