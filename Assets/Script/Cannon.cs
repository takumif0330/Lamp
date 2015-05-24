using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cannon : MonoBehaviour {

public GameObject prefab;
public float power;

public GameObject bullet0;
public GameObject bullet1;
public GameObject bullet2;
public GameObject bullet3;
public GameObject bullet4;
public GameObject bullet5;
public GameObject bullet6;
public GameObject bullet7;
public GameObject bullet8;
public GameObject bullet9;

Text ScoreText;

public float ScorePoint;
public Canvas canvas;

public int BallPoint;

public Sprite texture0;
public Sprite texture1;
public Sprite texture2;
public Sprite texture3;
public Sprite texture4;
public Sprite texture5;
public Sprite texture6;
public Sprite texture7;
public Sprite texture8;
public Sprite texture9;
public Sprite texture10;
public Sprite texture11;
public Sprite texture12;
public Sprite texture13;
public Sprite texture14;
public Sprite texture15;
public Sprite texture16;
public Sprite texture17;
public Sprite texture18;
public Sprite texture19;
public Sprite texture20;
public Sprite texture21;
public Sprite texture22;
public Sprite texture23;
public Sprite texture24;
public Sprite texture25;
public Sprite texture26;
public Sprite texture27;
public Sprite texture28;
public Sprite texture29;
public Sprite texture30;
public Sprite texture31;
public Sprite texture32;
public Sprite texture33;
public Sprite texture34;
public Sprite texture35;
public Sprite texture36;
public Sprite texture37;
public Sprite texture38;
public Sprite texture39;
public Sprite texture40;

GameObject tutorial1;
GameObject tutorial2;
GameObject tutorial3;

GameObject Light;

GameObject missFil;

AudioSource sound1;

bool multibool;

void Start(){
	tutorial1 = transform.Find("Default/TutorialPanel1").gameObject;
	tutorial2 = transform.Find("Default/TutorialPanel2").gameObject;
	tutorial3 = transform.Find("Default/TutorialPanel3").gameObject;

	Light = transform.Find("Spotlight").gameObject;

	missFil = transform.Find("Default/TutorialPanel3").gameObject;

	ScorePoint = 40;
	BallPoint = 0;

	multibool = true;
	}

void Update(){
	ScorePoint -= 0.1f;

	ScoreText = GetComponentInChildren<Text>();
	ScoreText.text = "" + ScorePoint;

	Light.light.range = ScorePoint;

	if(ScorePoint <= 0){
		ScorePoint = 0;
	}

	if(ScorePoint > 0){
		if (Input.GetMouseButtonDown(0)) {

		if(BallPoint == 10 && multibool == true){
			tutorial3.SetActive(true);
			StartCoroutine("Call3");
			multibool = false;
		}

		if(BallPoint < 10){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 dir = ray.direction.normalized;
			if(dir.x <= 0.6 || dir.y <= 0.2 ){

			LoadBullet0();

			bullet0.transform.parent = null;
			bullet0.rigidbody.velocity = dir * power;
			bullet0.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);
			ScorePoint--;
			}
		}else if(BallPoint < 20){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 dir = ray.direction.normalized;
			if(dir.x <= 0.6 || dir.y <= 0.2 ){

			LoadBullet1();

			bullet0.transform.parent = null;
			bullet0.rigidbody.velocity = dir * power;
			bullet0.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);

			bullet1.transform.parent = null;
			bullet1.rigidbody.velocity = dir * power;
			bullet1.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);
			ScorePoint--;
			}
		}else if(BallPoint < 30){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 dir = ray.direction.normalized;
			if(dir.x <= 0.6 || dir.y <= 0.2 ){

			LoadBullet2();

			bullet0.transform.parent = null;
			bullet0.rigidbody.velocity = dir * power;
			bullet0.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);

			bullet1.transform.parent = null;
			bullet1.rigidbody.velocity = dir * power;
			bullet1.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);

			bullet2.transform.parent = null;
			bullet2.rigidbody.velocity = dir * power;
			bullet2.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);
			ScorePoint--;
			}
		}else if(BallPoint < 40){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 dir = ray.direction.normalized;
			if(dir.x <= 0.6 || dir.y <= 0.2 ){

			LoadBullet3();

			bullet0.transform.parent = null;
			bullet0.rigidbody.velocity = dir * power;
			bullet0.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);

			bullet1.transform.parent = null;
			bullet1.rigidbody.velocity = dir * power;
			bullet1.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);

			bullet2.transform.parent = null;
			bullet2.rigidbody.velocity = dir * power;
			bullet2.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);

			bullet3.transform.parent = null;
			bullet3.rigidbody.velocity = dir * power;
			bullet3.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);

			ScorePoint--;
			}
		}else{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 dir = ray.direction.normalized;
			if(dir.x <= 0.6 || dir.y <= 0.2 ){

			LoadBullet4();

			bullet0.transform.parent = null;
			bullet0.rigidbody.velocity = dir * power;
			bullet0.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);

			bullet1.transform.parent = null;
			bullet1.rigidbody.velocity = dir * power;
			bullet1.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);

			bullet2.transform.parent = null;
			bullet2.rigidbody.velocity = dir * power;
			bullet2.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);

			bullet3.transform.parent = null;
			bullet3.rigidbody.velocity = dir * power;
			bullet3.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);

			bullet4.transform.parent = null;
			bullet4.rigidbody.velocity = dir * power;
			bullet4.transform.rigidbody.AddForce ( 0 , 4 , 0 , ForceMode.Impulse);
			ScorePoint--;
			}
		}

		}
	}

	if(BallPoint ==  0){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture9;		
	}
	else if(BallPoint == 1){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture8;		
	}
	else if(BallPoint == 2){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture7;
	}	else if(BallPoint == 3){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture6;		
	}	else if(BallPoint == 4){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture5;		
	}	else if(BallPoint == 5){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture4;		
	}	else if(BallPoint == 6){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture3;		
	}	else if(BallPoint == 7){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture2;		
	}	else if(BallPoint == 8){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture1;		
	}	else if(BallPoint == 9){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture0;		
	}	else if(BallPoint == 10){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture10;		
	}	else if(BallPoint == 11){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture11;		
	}	else if(BallPoint == 12){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture12;		
	}	else if(BallPoint == 13){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture13;		
	}	else if(BallPoint == 14){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture14;		
	}	else if(BallPoint == 15){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture15;		
	}	else if(BallPoint == 16){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture16;		
	}	else if(BallPoint == 17){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture17;		
	}	else if(BallPoint == 18){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture18;		
	}	else if(BallPoint == 19){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture19;		
	}	else if(BallPoint == 20){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture20;		
	}	else if(BallPoint == 21){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture21;		
	}	else if(BallPoint == 22){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture22;		
	}	else if(BallPoint == 23){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture23;		
	}	else if(BallPoint == 24){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture24;		
	}	else if(BallPoint == 25){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture25;		
	}	else if(BallPoint == 26){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture26;		
	}	else if(BallPoint == 27){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture27;		
	}	else if(BallPoint == 28){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture28;		
	}	else if(BallPoint == 29){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture29;		
	}	else if(BallPoint == 30){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture30;		
	}	else if(BallPoint == 31){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture31;		
	}	else if(BallPoint == 32){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture32;		
	}	else if(BallPoint == 33){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture33;		
	}	else if(BallPoint == 34){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture34;		
	}	else if(BallPoint == 35){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture35;		
	}	else if(BallPoint == 36){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture36;		
	}	else if(BallPoint == 37){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture37;		
	}	else if(BallPoint == 38){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture38;		
	}	else if(BallPoint == 39){
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture39;		
	}	else{
		GameObject BallImg = transform.FindChild("Default/Image").gameObject;
		BallImg.GetComponent<Image>().sprite = texture40;		
	}
}

void OnTriggerEnter(Collider collider){
	if(collider.gameObject.name == "TutorialPoint1"){
	tutorial1.SetActive(true);
	StartCoroutine("Call1");
		}

	if(collider.gameObject.name == "TutorialPoint2"){
	tutorial2.SetActive(true);
	StartCoroutine("Call2");
		}

	if(collider.gameObject.tag == "obs_all"){
		missFil.SetActive(true);
		iTween.ShakePosition(gameObject,iTween.Hash("y",0.8f,"time",0.3f));

		ScorePoint -= 10;
		BallPoint = 0;

		sound1 = gameObject.audio;
		sound1.PlayOneShot(sound1.clip);

		miss();

		bullet0.transform.parent = null;
		bullet1.transform.parent = null;
		bullet2.transform.parent = null;
		bullet3.transform.parent = null;
		bullet4.transform.parent = null;
		bullet5.transform.parent = null;
		bullet6.transform.parent = null;
		bullet7.transform.parent = null;
		bullet8.transform.parent = null;
		bullet9.transform.parent = null;

		bullet0.transform.rigidbody.AddForce ( 0 , 4 , 8 , ForceMode.Impulse);
		bullet1.transform.rigidbody.AddForce ( 0 , 4 , 8 , ForceMode.Impulse);
		bullet2.transform.rigidbody.AddForce ( 0 , 4 , 8 , ForceMode.Impulse);
		bullet3.transform.rigidbody.AddForce ( 0 , 4 , 8 , ForceMode.Impulse);
		bullet4.transform.rigidbody.AddForce ( 0 , 4 , 8 , ForceMode.Impulse);
		bullet5.transform.rigidbody.AddForce ( 0 , 4 , 8 , ForceMode.Impulse);
		bullet6.transform.rigidbody.AddForce ( 0 , 4 , 8 , ForceMode.Impulse);
		bullet7.transform.rigidbody.AddForce ( 0 , 4 , 8 , ForceMode.Impulse);
		bullet8.transform.rigidbody.AddForce ( 0 , 4 , 8 , ForceMode.Impulse);
		bullet9.transform.rigidbody.AddForce ( 0 , 4 , 8 , ForceMode.Impulse);

		StartCoroutine("MissC");
	}
}

GameObject LoadBullet0 (){
	bullet0 = GameObject.Instantiate( prefab ) as GameObject;
	bullet0.transform.parent = transform;
	bullet0.transform.localPosition = new Vector3(0f, -0.3f, 0f);
	return bullet0;
	}

GameObject LoadBullet1 (){
	bullet0 = GameObject.Instantiate( prefab ) as GameObject;
	bullet1 = GameObject.Instantiate( prefab ) as GameObject;

	bullet0.transform.parent = transform;
	bullet1.transform.parent = transform;

	bullet0.transform.localPosition = new Vector3(-0.2f, -0.3f, 0f);
	bullet1.transform.localPosition = new Vector3(0.2f, -0.3f, -0.1f);

	return bullet0;
	return bullet1;
	}

GameObject LoadBullet2 (){
	bullet0 = GameObject.Instantiate( prefab ) as GameObject;
	bullet1 = GameObject.Instantiate( prefab ) as GameObject;
	bullet2 = GameObject.Instantiate( prefab ) as GameObject;

	bullet0.transform.parent = transform;
	bullet1.transform.parent = transform;
	bullet2.transform.parent = transform;

	bullet0.transform.localPosition = new Vector3(-0.2f, -0.5f, 0f);
	bullet1.transform.localPosition = new Vector3(0.2f, -0.5f, 0f);
	bullet2.transform.localPosition = new Vector3(0f, -0.1f, 0f);

	return bullet0;
	return bullet1;
	return bullet2;
	}

GameObject LoadBullet3 (){
	bullet0 = GameObject.Instantiate( prefab ) as GameObject;
	bullet1 = GameObject.Instantiate( prefab ) as GameObject;
	bullet2 = GameObject.Instantiate( prefab ) as GameObject;
	bullet3 = GameObject.Instantiate( prefab ) as GameObject;

	bullet0.transform.parent = transform;
	bullet1.transform.parent = transform;
	bullet2.transform.parent = transform;
	bullet3.transform.parent = transform;

	bullet0.transform.localPosition = new Vector3(-0.2f, -0.5f, 0f);
	bullet1.transform.localPosition = new Vector3(0.2f, -0.5f, 0f);
	bullet2.transform.localPosition = new Vector3(-0.2f, -0.1f, 0f);
	bullet3.transform.localPosition = new Vector3(0.2f, -0.1f, 0f);

	return bullet0;
	return bullet1;
	return bullet2;
	return bullet3;
	}

GameObject LoadBullet4 (){
	bullet0 = GameObject.Instantiate( prefab ) as GameObject;
	bullet1 = GameObject.Instantiate( prefab ) as GameObject;
	bullet2 = GameObject.Instantiate( prefab ) as GameObject;
	bullet3 = GameObject.Instantiate( prefab ) as GameObject;
	bullet4 = GameObject.Instantiate( prefab ) as GameObject;

	bullet0.transform.parent = transform;
	bullet1.transform.parent = transform;
	bullet2.transform.parent = transform;
	bullet3.transform.parent = transform;
	bullet4.transform.parent = transform;

	bullet0.transform.localPosition = new Vector3(-0.2f, -0.5f, 0f);
	bullet1.transform.localPosition = new Vector3(0.2f, -0.5f, 0f);
	bullet2.transform.localPosition = new Vector3(-0.2f, -0.1f, 0f);
	bullet3.transform.localPosition = new Vector3(0.2f, -0.1f, 0f);
	bullet4.transform.localPosition = new Vector3(0f, -0.3f, 0f);

	return bullet0;
	return bullet1;
	return bullet2;
	return bullet3;
	return bullet4;
	}

GameObject miss (){

	bullet0 = GameObject.Instantiate( prefab ) as GameObject;
	bullet1 = GameObject.Instantiate( prefab ) as GameObject;
	bullet2 = GameObject.Instantiate( prefab ) as GameObject;
	bullet3 = GameObject.Instantiate( prefab ) as GameObject;
	bullet4 = GameObject.Instantiate( prefab ) as GameObject;
	bullet5 = GameObject.Instantiate( prefab ) as GameObject;
	bullet6 = GameObject.Instantiate( prefab ) as GameObject;
	bullet7 = GameObject.Instantiate( prefab ) as GameObject;
	bullet8 = GameObject.Instantiate( prefab ) as GameObject;
	bullet9 = GameObject.Instantiate( prefab ) as GameObject;

	bullet0.transform.parent = transform;
	bullet1.transform.parent = transform;
	bullet2.transform.parent = transform;
	bullet3.transform.parent = transform;
	bullet4.transform.parent = transform;
	bullet5.transform.parent = transform;
	bullet6.transform.parent = transform;
	bullet7.transform.parent = transform;
	bullet8.transform.parent = transform;
	bullet9.transform.parent = transform;

	bullet0.transform.localPosition = new Vector3(-0.2f, -0.5f, 0f);
	bullet1.transform.localPosition = new Vector3(0.2f, -0.5f, 0f);
	bullet2.transform.localPosition = new Vector3(-0.2f, -0.1f, 0f);
	bullet3.transform.localPosition = new Vector3(0.2f, -0.1f, 0f);
	bullet4.transform.localPosition = new Vector3(0f, -0.3f, 0f);
	bullet5.transform.localPosition = new Vector3(-0.4f, -0.5f, 0f);
	bullet6.transform.localPosition = new Vector3(0.4f, -0.5f, 0f);
	bullet7.transform.localPosition = new Vector3(-0.3f, -0.3f, 0f);
	bullet8.transform.localPosition = new Vector3(0.3f, -0.3f, 0f);
	bullet9.transform.localPosition = new Vector3(0f, -0.5f, 0f);

	return bullet0;
	return bullet1;
	return bullet2;
	return bullet3;
	return bullet4;
	return bullet5;
	return bullet6;
	return bullet7;
	return bullet8;
	return bullet9;
	}


IEnumerator Call1(){
	yield return new WaitForSeconds(3f);
	Destroy(tutorial1);
	}

IEnumerator Call2(){
	yield return new WaitForSeconds(3f);
	Destroy(tutorial2);
	}

IEnumerator Call3(){
	yield return new WaitForSeconds(3f);
	Destroy(tutorial3);
	}

IEnumerator MissC(){
	yield return new WaitForSeconds(1.5f);
	missFil.SetActive(false);
	}

}