using UnityEngine;

public class TargetController : MonoBehaviour {

	[SerializeField] private Animator anim;
	private int hitCount;

	// Use this for initialization
	void Start () {
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
