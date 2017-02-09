using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {

	Animator anim;
	private int hitCount;

	// Use this for initialization
	void Start () {
		anim =  transform.parent.gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Hit(){
		hitCount++;
		print (hitCount);
		if (hitCount == 5) {
			anim.SetBool ("broken", true);
			hitCount = 0;
			Invoke("Revival", 10f);
		}
	}

	private void Revival(){
		anim.SetBool ("broken", false);
	}

}
