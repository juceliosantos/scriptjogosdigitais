using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayTime : MonoBehaviour {

	public int minutesText, secondsText, secondsCurrent;
	public float seconds;

	private int id=1, timePlay = 60;

	// Update is called once per frame
	void Update () {
		Timer ();
	}

	void Timer() {
		seconds = Time.timeSinceLevelLoad;
		secondsCurrent = (int)Mathf.Ceil(seconds);      //Converting the rhythm of Execution For Full
		if (secondsCurrent < timePlay){
			minutesText = 0;
			secondsText = secondsCurrent;
		}
		if (secondsCurrent >= timePlay){
			if (secondsCurrent / timePlay == id){
				minutesText += 1;
				secondsText = secondsCurrent - timePlay * (id-1);
				id += 1;
			}
			if (secondsCurrent / timePlay != id){
				secondsText = secondsCurrent - timePlay * (id-1);
			}
		}
		GetComponent<Text>().text = minutesText + ":" + secondsText;
	}
}