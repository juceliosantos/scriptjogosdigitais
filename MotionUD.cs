using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionUD : MonoBehaviour {

	public float speed, timeExecutation;
	private float timeMotion;
	private bool isDown = true;

	// Update is called once per frame
	void Update () {

		Motion ();

	}

	void Motion(){
		timeMotion += Time.deltaTime;

		if (timeMotion <= timeExecutation) {
			if (isDown) {
				transform.Translate (Vector2.down * speed * Time.deltaTime);
				transform.eulerAngles = new Vector2 (0, 0);
			} else {
				transform.Translate (Vector2.down * speed * Time.deltaTime);
				transform.eulerAngles = new Vector2 (180, 0);
			}
		} else {
			isDown = !isDown;
			timeMotion = 0;
		}
	}

}
