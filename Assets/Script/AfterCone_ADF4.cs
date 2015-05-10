using UnityEngine;
using System.Collections;

public class AfterCone_ADF4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3(Random.Range(0.5f, 1.0f),Random.Range(0.9f, 1.0f),Random.Range(0.5f, 1.5f));
		rigidbody.useGravity = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		try{

		if(collision.gameObject.tag == "Bullet"){

		float r = Random.Range(0.5f, 1.0f);
		transform.rigidbody.AddForce(Random.Range(-1.5f, 1.5f), 1.5f * r ,r,ForceMode.Impulse);
		}
		}catch(System.Exception e){}
	}
}