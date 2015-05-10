using UnityEngine;
using System.Collections;

public class DoorOpen : MonoBehaviour {

	public AudioClip sound01;


	// Use this for initialization
	void Start () {
		GameObject ArrowR = transform.FindChild("ArrowL").gameObject;
		GameObject ArrowL = transform.FindChild("ArrowR").gameObject;

			//右矢印
			AnimationClip clipAL = new AnimationClip();

			AnimationCurve curveAL_x = AnimationCurve.Linear(0f,0.9f,1.2f,0.9f);
			Keyframe keyAL = new Keyframe(0.6f,1.3f);
			curveAL_x.AddKey(keyAL);
			clipAL.SetCurve("", typeof(Transform), "localPosition.x", curveAL_x);
			clipAL.wrapMode = WrapMode.Loop;

			AnimationCurve curveAL_y = AnimationCurve.Linear(0f,0f,1f,0f);
			clipAL.SetCurve("", typeof(Transform), "localPosition.y", curveAL_y);

			AnimationCurve curveAL_z = AnimationCurve.Linear(0f,0f,1f,0f);
			clipAL.SetCurve("", typeof(Transform), "localPosition.z", curveAL_z);

			//左とびら
			AnimationClip clipAR = new AnimationClip();

			AnimationCurve curveAR_x = AnimationCurve.Linear(0f,-0.9f,1.2f,-0.9f);
			Keyframe keyAR = new Keyframe(0.6f,-1.3f);
			curveAR_x.AddKey(keyAR);
			clipAR.SetCurve("", typeof(Transform), "localPosition.x", curveAR_x);
			clipAR.wrapMode = WrapMode.Loop;

			AnimationCurve curveAR_y = AnimationCurve.Linear(0f,0f,1f,0f);
			clipAR.SetCurve("", typeof(Transform), "localPosition.y", curveAR_y);

			AnimationCurve curveAR_z = AnimationCurve.Linear(0f,0f,1f,0f);
			clipAR.SetCurve("", typeof(Transform), "localPosition.z", curveAR_z);

			ArrowR.animation.AddClip(clipAR, "animAR");
			ArrowR.animation.Play("animAR");
			ArrowL.animation.AddClip(clipAL, "animAL");
			ArrowL.animation.Play("animAL");
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision){
		Texture SWOFF = (Texture)Resources.Load("switch_off");

		GameObject ArrowR = transform.FindChild("ArrowR").gameObject;
		GameObject ArrowL = transform.FindChild("ArrowL").gameObject;
		GameObject DL = transform.FindChild("Door_left").gameObject;
		GameObject DR = transform.FindChild("Door_right").gameObject;

		if(collision.gameObject.tag == "Bullet"){

			audio.PlayOneShot(sound01);

			ArrowR.SetActive(false);
			ArrowL.SetActive(false);
			renderer.material.mainTexture = SWOFF;

			//右とびら
			AnimationClip clipDL = new AnimationClip();

			AnimationCurve curveDL_x = AnimationCurve.Linear(0f,0f,1f,1f);
			clipDL.SetCurve("", typeof(Transform), "localPosition.x", curveDL_x);
			clipDL.wrapMode = WrapMode.Once;

			AnimationCurve curveDL_y = AnimationCurve.Linear(0f,-2.5f,1f,-2.5f);
			clipDL.SetCurve("", typeof(Transform), "localPosition.y", curveDL_y);

			AnimationCurve curveDL_z = AnimationCurve.Linear(0f,0f,1f,0f);
			clipDL.SetCurve("", typeof(Transform), "localPosition.z", curveDL_z);

			//左とびら
			AnimationClip clipDR = new AnimationClip();

			AnimationCurve curveDR_x = AnimationCurve.Linear(0f,0f,1f,-1f);
			clipDR.SetCurve("", typeof(Transform), "localPosition.x", curveDR_x);
			clipDR.wrapMode = WrapMode.Once;

			AnimationCurve curveDR_y = AnimationCurve.Linear(0f,-2.5f,1f,-2.5f);
			clipDR.SetCurve("", typeof(Transform), "localPosition.y", curveDR_y);

			AnimationCurve curveDR_z = AnimationCurve.Linear(0f,0f,1f,0f);
			clipDR.SetCurve("", typeof(Transform), "localPosition.z", curveDR_z);

			DR.animation.AddClip(clipDR, "animDR");
			DR.animation.Play("animDR");
			DL.animation.AddClip(clipDL, "animDL");
			DL.animation.Play("animDL");
		}
	}
}