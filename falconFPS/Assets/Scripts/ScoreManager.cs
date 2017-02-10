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
		float distance = Vector3.Distance (hitposition, HeadMarker.transform.position);
		if (distance == 0f) {
			score += 100;
		} else {
			score += 100 / (int)distance; //距離が大きいほど加点が減る
		}
		print (score);
	}

}
