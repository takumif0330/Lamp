using UnityEngine;
using System.Collections;

public class ConeShineAnim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate(new Vector3(0f,0.2f,0f));
	}
}