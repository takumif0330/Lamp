using UnityEngine;
using System.Collections;

public class newMap1 : MonoBehaviour {

public GameObject prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){
	if(collider.gameObject.name == "MainCamera"){
		Instantiate(prefab,new Vector3(0,2.3f,transform.position.z + 50),Quaternion.identity);
		}
	}
}