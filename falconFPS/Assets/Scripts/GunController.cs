using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

	[SerializeField] private int bulletBox;
	[SerializeField] private int bullet;
	[SerializeField] private GameObject firePrefs;

	[SerializeField] private AudioClip shotSound;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

		Ray ray = new Ray(transform.position, transform.up);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit)) {
			if (Input.GetMouseButton (0)) {
				GameObject fire = Instantiate (firePrefs);
				fire.transform.position = hit.point;
				audioSource.PlayOneShot (shotSound);
				Destroy (fire, 0.5f);

			}
		}
	}
		
}
