using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

	[SerializeField] private int bulletBox;
	[SerializeField] private int bullet;
	[SerializeField] private GameObject firePrefs;
	[SerializeField] private GameObject fireMuzzlePrefs;
	[SerializeField] private AudioClip shotSound;
	[SerializeField] private AudioClip reloadSound;
	[SerializeField] private GameObject muzzle;

	AudioSource audioSource;

	public bool isEmpty; 
	private int useBullet;


	// Use this for initialization
	void Start () {
		isEmpty = false;
		audioSource = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
	}
		
	public void Shot(Vector3 hitposition){
		GameObject firehit = Instantiate (firePrefs);
		firehit.transform.position = hitposition;
		GameObject firemuzzle = Instantiate (fireMuzzlePrefs);
		firemuzzle.transform.position = muzzle.transform.position;
		audioSource.PlayOneShot (shotSound);

		Destroy (firehit, 0.5f);
		Destroy (firemuzzle, 0.3f);
	}

	public void UseBullet(){
		bullet--;
		if (bullet == 0) {
			isEmpty = true;
		}
	}

	public void ReloadBullet(){
		useBullet = 0;
		useBullet = 30 - bullet;
		if (useBullet != 0 && bulletBox != 0) { // 使用数が0のとき 弾倉が0のときはリロード出来ない
			if (bulletBox >= useBullet) { // 弾倉 >= 使用数 のとき 使用数分補充
				bulletBox -= useBullet;
				bullet += useBullet;
				audioSource.PlayOneShot (reloadSound);
			} else {                      // 弾倉 < 使用数 のとき 残り弾倉を補充
				bullet += bulletBox;
				bulletBox = 0;
				audioSource.PlayOneShot (reloadSound);
			}
		}
	}

}
