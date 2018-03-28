using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;

	private float smooth = 0.25f;
	private Vector2 speed = new Vector2 (0.5f, 0.5f);
	private Vector2 newPosition2D = new Vector2 (0f, 0f);

	// Update is called once per frame
	void Update () {
		Follow ();
	}

	void Follow(){
		newPosition2D.x = Mathf.SmoothDamp (transform.position.x, player.transform.position.x, ref speed.x, smooth);
		newPosition2D.y = Mathf.SmoothDamp (transform.position.y, player.transform.position.y, ref speed.y, smooth);
		Vector3 newPosition3D = new Vector3 (newPosition2D.x, newPosition2D.y, transform.position.z);
		transform.position = Vector3.Slerp (transform.position, newPosition3D, Time.time);
	}
}
