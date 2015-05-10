using UnityEngine;
using System.Collections;

public class bullet_rb : MonoBehaviour {

	public AudioClip sound01;
	// Use this for initialization
	void Start () {
		StartCoroutine("Dragup");
	}

	void OnCollisionEnter(Collision collision){
		audio.PlayOneShot(sound01);
	}


	private IEnumerator Dragup(){
		yield return new WaitForSeconds(0.8f);
		rigidbody.drag = 2.0f;
	}
}