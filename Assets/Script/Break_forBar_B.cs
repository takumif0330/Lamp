using UnityEngine;
using System.Collections;

public class Break_forBar_B : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider collider){

		try{

		GameObject AconeA = transform.FindChild("Horizontal_bar_011").gameObject;
		GameObject AconeB = transform.FindChild("Horizontal_bar_023").gameObject;
		GameObject AconeC = transform.FindChild("Horizontal_bar_012").gameObject;
		GameObject AconeD = transform.FindChild("Horizontal_bar_029").gameObject;

		GameObject fragment = transform.FindChild("fragment").gameObject;

		if(collider.gameObject.tag == "Bullet"){
			float r = Random.value;

			AconeA.AddComponent("Rigidbody");
			AconeB.AddComponent("Rigidbody");
			AconeC.AddComponent("Rigidbody");
			AconeD.AddComponent("Rigidbody");

			AconeA.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);
			AconeB.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);
			AconeC.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);
			AconeD.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);

			AconeA.transform.parent = null;
			AconeB.transform.parent = null;
			AconeC.transform.parent = null;
			AconeD.transform.parent = null;

			fragment.SetActive(true);
			}
		}catch(System.Exception e){}
	}
}