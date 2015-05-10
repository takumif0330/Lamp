using UnityEngine;
using System.Collections;

public class PointAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AnimationClip clip = new AnimationClip();
		AnimationCurve curve = AnimationCurve.Linear(0f,0.5f,1f,1f);
		clip.SetCurve("", typeof(Transform), "localPosition.y", curve);
		clip.wrapMode = WrapMode.Once;
		animation.AddClip(clip,"clip_point");
		animation.Play("clip_point");
		iTween.FadeTo(gameObject, iTween.Hash("alpha", 0, "time", 1.5f));

	}
	
	// Update is called once per frame
	void Update () {
	}
}