using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Mask : MonoBehaviour {

	public Texture2D[] airCurrent;
	private int counter= 0,  id=1, thetime = 1;

	private PlayTime playtime;

	//When Wake Play
	void Awake (){
		playtime = FindObjectOfType(typeof(PlayTime)) as PlayTime;
	}

	// Use this for initialization
	void Start (){
		GetComponent<RawImage>().texture = airCurrent[0];
	}

	// Update is called once per frame
	void Update () {
		LevelTime ();
	}

	//Method to control the level of air according to the time
	public void LevelTime(){
		if(playtime.secondsCurrent/thetime == id){
			counter += 1;
			GetComponent<RawImage>().texture = airCurrent[counter];
			id +=1; 
		}
		if(counter == 26){
			Application.LoadLevel(1);
		}
	}
}