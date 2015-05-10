using UnityEngine;
using System.Collections;

public class AfterCone_ADF1 : MonoBehaviour {

		float r;
		float m;
		float l;

		float t;
	// Use this for initialization

	void Start () {
		r = Random.value;
		m = Random.value;
		t = Random.Range(1f, 1.2f);

		transform.localScale = new Vector3(Random.Range(0.8f, 1f),Random.Range(0.8f, 0.9f),Random.Range(0.9f, 1.0f));
		rigidbody.useGravity = true;
		transform.rigidbody.AddForce(Random.Range(-0.5f, 0.5f), Random.Range(1f,1.2f), Random.Range(0.1f,0.5f), ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision){
		t = 0;

		try{

		if(collision.gameObject.tag == "Bullet"){

		if(m <= 0.5){
			l = -1;
		}
		else{
			l = 1;
		}
		transform.Rotate(new Vector3(r * 80,m,r));	
		transform.rigidbody.AddForce(r * l ,1 , 1, ForceMode.Impulse);
		r = 0;
		m =0;

		t = Random.Range(1f, 1.2f);				}
		}catch(System.Exception e){}
	}
}
