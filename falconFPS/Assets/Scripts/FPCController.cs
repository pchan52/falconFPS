using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCController : MonoBehaviour {

	[SerializeField] GameObject gunobj;
	[SerializeField] GameObject scoreManager;
	[SerializeField] LayerMask layermask;
	[SerializeField] float offset;

	GunController gun;
	ScoreManager score;

	public int sniper = -1; // -1 : not sniper  1 : sniper
	// Use this for initialization
	void Start () {
		gun = gunobj.GetComponent<GunController> ();
		score = scoreManager.GetComponent<ScoreManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, layermask)) {
			if (Input.GetMouseButton (0) && !gun.isEmpty) {
				gun.Shot (hit.point);
				gun.UseBullet ();
				TargetController target = hit.collider.gameObject.GetComponent<TargetController> ();
				if (target != null) {
					target.Hit ();
					score.CalcScore (hit.point);
				}
			}
		}

		if(Input.GetKeyDown(KeyCode.R)){
			gun.ReloadBullet ();
		}

		if (Input.GetMouseButton (1)) {
			sniper = sniper * (-1);
			if (sniper == -1) {
				transform.position -= new Vector3 (0, 0, offset);
			} else {
				transform.position += new Vector3 (0, 0, offset);
			}
		}
	}
}
