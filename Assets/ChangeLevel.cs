using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour {
	public void ChangeScene(string sceneName) {
		Application.LoadLevel(sceneName);
	}

}
