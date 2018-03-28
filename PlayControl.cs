using UnityEngine;
using System.Collections;

public class PlayControl : MonoBehaviour {

	public GameObject player;
	public float maxHeight, speed;

	// Update is called once per frame
	void Update () {
		Swim ();
	}


	//Method to make the character swim
	void Swim(){
		//Movement to Left
		if (Input.GetAxis("Horizontal")>0){
			player.transform.eulerAngles = new Vector2(0,0);
			float rotation = Input.GetAxis ("Horizontal")*speed;
			player.transform.Translate (rotation,0,0);
		}

		//Movement for Right
		if (Input.GetAxis("Horizontal")<0){
			player.transform.eulerAngles = new Vector2(0,180);
			float rotation = Input.GetAxis ("Horizontal")*speed;
			player.transform.Translate (-rotation,0,0);
		}

		//Upward movement
		if (Input.GetAxis("Vertical")>0 || Input.GetAxis("Vertical")<0){
			float rotation = Input.GetAxis ("Vertical")*speed;
			player.transform.Translate (0,rotation,0);	
		}

		//Limit maximum height and the level of air knew
		if (player.transform.position.y > maxHeight) {
			player.transform.position = new Vector3 (player.transform.position.x, maxHeight, 0);
		}
	}
}