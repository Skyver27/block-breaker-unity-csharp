using UnityEngine;
using System.Collections;

public class GameMusic : MonoBehaviour {
	static GameMusic instance = null;
	
	void Awake () {
		if (instance != null) {
			Destroy (gameObject);
			print ("Duplicate game music self-destructing");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
