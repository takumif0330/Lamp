using UnityEngine;
using System.Collections;

public class Break_forBar_A : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider collider){

		try{

		GameObject AconeA = transform.FindChild("Horizontal_bar_005").gameObject;
		GameObject AconeB = transform.FindChild("Horizontal_bar_014").gameObject;
		GameObject AconeC = transform.FindChild("Horizontal_bar_006").gameObject;
		GameObject AconeD = transform.FindChild("Horizontal_bar_002").gameObject;
		GameObject AconeE = transform.FindChild("Horizontal_bar_004").gameObject;
		GameObject AconeF = transform.FindChild("Horizontal_bar_028").gameObject;
		GameObject AconeG = transform.FindChild("Horizontal_bar_010").gameObject;
		GameObject AconeH = transform.FindChild("Horizontal_bar_001").gameObject;

		GameObject fragment = transform.FindChild("fragment").gameObject;

		if(collider.gameObject.tag == "Bullet"){

			float r = Random.value;

			AconeA.AddComponent("Rigidbody");
			AconeB.AddComponent("Rigidbody");
			AconeC.AddComponent("Rigidbody");
			AconeD.AddComponent("Rigidbody");
			AconeE.AddComponent("Rigidbody");
			AconeF.AddComponent("Rigidbody");
			AconeG.AddComponent("Rigidbody");
			AconeH.AddComponent("Rigidbody");

			AconeA.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);
			AconeB.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);
			AconeC.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);
			AconeD.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);
			AconeE.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);
			AconeF.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);
			AconeG.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);
			AconeH.rigidbody.AddForce(Random.Range(-5f, 5f), 3 * r, 5 * r, ForceMode.Impulse);

			AconeA.transform.parent = null;
			AconeB.transform.parent = null;
			AconeC.transform.parent = null;
			AconeD.transform.parent = null;
			AconeE.transform.parent = null;
			AconeF.transform.parent = null;
			AconeG.transform.parent = null;
			AconeH.transform.parent = null;

			fragment.SetActive(true);
			}
		}catch(System.Exception e){}
	}
}