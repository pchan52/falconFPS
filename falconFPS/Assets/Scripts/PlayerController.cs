using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerController : MonoBehaviour {

	FirstPersonController fps;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.C)) {
			transform.position = new Vector3 (transform.position.x, 4f, transform.position.z);
			gameObject.GetComponent<FirstPersonController>().m_WalkSpeed = 2f;
		}
		
	}
}
