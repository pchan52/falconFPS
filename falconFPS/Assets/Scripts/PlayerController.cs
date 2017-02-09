using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] GameObject gunobj;
	GunController gun;

	// Use this for initialization
	void Start () {
		gun = gunobj.GetComponent<GunController> ();
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit)) {
			if (Input.GetMouseButton (0) && !gun.isEmpty) {

				gun.Shot (hit.point);
				gun.UseBullet ();
			}
		}
	}
}
