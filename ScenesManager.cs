using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesManager : MonoBehaviour {

	public void NextLevel(string scenes) {
		Application.LoadLevel(scenes);
	}

	public void NextLevelInt(int scenes) {
		Application.LoadLevel(scenes);
	}
}