using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCController : MonoBehaviour {

	[SerializeField] GunController gun;
	[SerializeField] ScoreManager score;
	[SerializeField] LayerMask layermask;
	[SerializeField] Camera camera;
	[SerializeField] float offset;

	public int sniper = -1; // -1 : not sniper  1 : sniper
	// Use this for initialization
	void Start () {
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
			
		Reload ();
		Snip ();

	}

	void Reload(){
		if(Input.GetKeyDown(KeyCode.R)){
			gun.ReloadBullet ();
		}
	}

	void Snip(){
		if (Input.GetMouseButton (1)) {
			sniper = sniper * (-1);
			if (sniper == -1) {
				camera.fieldOfView += offset;
			} else {
				camera.fieldOfView -= offset;
			}
		}
	}
		
}
