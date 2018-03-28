using System.Collections.Generic;
using UnityEngine;

public class MotionLR : MonoBehaviour {

	public float speed, timeExecution;
	private float timeMotion;
	private bool isLeft = true;

	// Update is called once per frame
	void Update () {
		Motion ();
	}

	//Left to Right Movement (vise-versa)
	void Motion(){
		timeMotion += Time.deltaTime;
		if (timeMotion <= timeExecution) {
			if (isLeft) {
				transform.Translate (Vector2.left * speed * Time.deltaTime);
				transform.eulerAngles = new Vector2 (0, 0);
			} else {
				transform.Translate (Vector2.left * speed * Time.deltaTime);
				transform.eulerAngles = new Vector2 (0,180);
			}
		}
		else {
			isLeft= !isLeft;
			timeMotion = 0;
		}
	}
}