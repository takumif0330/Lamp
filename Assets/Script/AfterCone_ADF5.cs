using UnityEngine;
using System.Collections;

public class AfterCone_ADF5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.useGravity = true;
		transform.localScale = new Vector3(Random.Range(0.5f, 1.1f),Random.Range(0.9f, 1.0f),Random.Range(0.5f, 1.5f));

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		try{

		if(collision.gameObject.tag == "Bullet"){

		float r = Random.Range(0.5f, 1.0f);
		float m = Random.Range(0.5f, 1.0f);
		float l;

		if(m <= 0.5){
			l = -1;
		}
		else{
			l = 1;
		}
		transform.rigidbody.AddForce(1.5f * l * r, 1.1f * r , r, ForceMode.Impulse);
		}
		}catch(System.Exception e){}
	}
}