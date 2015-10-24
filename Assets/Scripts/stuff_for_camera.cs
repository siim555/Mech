using UnityEngine;
using System.Collections;

public class stuff_for_camera : MonoBehaviour {
	public static ScreenOrientation orientation;
	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;

	
	}
	
	// Update is called once per frame
	void Update () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}
	}
}
