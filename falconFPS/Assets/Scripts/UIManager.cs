using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	[SerializeField] private Image Sniper;
	[SerializeField] private Text LeftTime;
	[SerializeField] private Text Score;
	[SerializeField] private Text Bullet;
	[SerializeField] private Text BulletBox;
	[SerializeField] private ScoreManager scoreManager;
	[SerializeField] private GunController gunController;
	[SerializeField] private FPCController FPCController;

	private float time;

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

		if (FPCController.sniper == -1) {
			Sniper.enabled = false;
		} else {
			Sniper.enabled = true;
		}
	}
}
