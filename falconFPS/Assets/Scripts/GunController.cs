using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

	[SerializeField] private int bulletBox;
	[SerializeField] private int bullet;
	[SerializeField] private GameObject firePrefs;
	[SerializeField] private GameObject fireMuzzlePrefs;
	[SerializeField] private AudioClip shotSound;
	[SerializeField] private GameObject muzzle;

	AudioSource audioSource;

	public bool isEmpty; 


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

}
