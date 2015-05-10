using UnityEngine;
using System.Collections;

public class TagChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		this.tag = ("Untagged");
	}
}