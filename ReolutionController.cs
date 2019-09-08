using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReolutionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.AutoRotation; 
		Screen.autorotateToLandscapeLeft =false;
		Screen.autorotateToLandscapeRight =false;
		Screen.autorotateToPortrait = true;
		Screen.autorotateToPortraitUpsideDown = true;
	}

}
