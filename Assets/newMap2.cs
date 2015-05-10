using UnityEngine;
using System.Collections;

public class newMap2 : MonoBehaviour {

public GameObject prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){
	if(collider.gameObject.name == "MainCamera"){
		Instantiate(prefab,new Vector3(0.5f,1f,transform.position.z + 6),Quaternion.identity);
		}
	}
}