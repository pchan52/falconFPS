using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	[SerializeField] Text LeftTime;
	[SerializeField] Text Score;
	[SerializeField] Text Bullet;
	[SerializeField] Text BulletBox;
	[SerializeField] GameObject scoreManager;
	[SerializeField] GameObject gunController;

	ScoreManager sm;
	GunController gc;
	float time;

	// Use this for initialization
	void Start () {
		sm = scoreManager.GetComponent<ScoreManager> ();
		gc = gunController.GetComponent<GunController> ();
	}
	
	// Update is called once per frame
	void Update () {
		time = 90.0f - Time.time;
		LeftTime.text = "Time : " + time.ToString("N1") + "s";
		Score.text = "Pt : " + sm.score;
		Bullet.text = "Bullet : " + gc.bullet + "/30";
		BulletBox.text = "BulletBox : " + gc.bulletBox;
	}
}
