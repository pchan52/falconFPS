using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

	[SerializeField] private int bulletBox;
	[SerializeField] private int bullet;
	[SerializeField] private GameObject firePrefs;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		Ray ray = new Ray(transform.position, transform.up);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit)) {
			if (Input.GetMouseButton (0)) {
				GameObject fire = Instantiate (firePrefs);
				firePrefs.transform.position = hit.point;
				Destroy (fire, 0.5f);

			}
		}
	}
		
}
