using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<FirstPersonController>().m_WalkSpeed = 5f;

		if (Input.GetKey (KeyCode.C)) {
			transform.position = new Vector3 (transform.position.x, 4.0f, transform.position.z);
			gameObject.GetComponent<FirstPersonController>().m_WalkSpeed = 2f;
		}
		
	}
}
