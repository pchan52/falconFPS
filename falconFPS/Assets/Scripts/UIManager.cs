using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	[SerializeField] Text LeftTime;
	[SerializeField] Text Score;
	[SerializeField] Text Bullet;
	[SerializeField] Text BulletBox;
	[SerializeField] ScoreManager scoreManager;
	[SerializeField] GunController gunController;

	float time;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		time = 90.0f - Time.time;
		LeftTime.text = "Time : " + time.ToString("N1") + "s";
		Score.text = "Pt : " + scoreManager.score;
		Bullet.text = "Bullet : " + gunController.bullet + "/30";
		BulletBox.text = "BulletBox : " + gunController.bulletBox;
	}
}
