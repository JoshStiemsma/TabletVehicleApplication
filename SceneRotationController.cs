﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneRotationController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.autorotateToPortraitUpsideDown = true;
		Screen.autorotateToPortrait = true;
		Screen.autorotateToLandscapeLeft = false;
		Screen.autorotateToLandscapeRight = false;

		Screen.orientation = ScreenOrientation.Portrait;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
