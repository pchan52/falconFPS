using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	[SerializeField] private GameObject HeadMarker;

	private int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CalcScore(Vector3 hitposition){
		Vector2 hitposition2 = hitposition; 
		Vector2 headmarker2 = HeadMarker.transform.position;
		float distance = Vector2.Distance (hitposition2, headmarker2); //x-y平面における距離にする
		print(distance);
		score += Score (distance);
		print (score);
	}

	private int Score(float distance){
		if (distance < 0.04f) {
			return 100;
		} else if (distance < 0.08f) {
			return 90;
		} else if (distance < 0.12f) {
			return 80;
		} else if (distance < 0.16f) {
			return 70;
		} else if (distance < 0.20f) {
			return 60;
		}else{
			return 50;
		}
	}

}
