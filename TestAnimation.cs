using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimation : MonoBehaviour {

    public string AnimationName;
    public bool startAnim = false;

	
	// Update is called once per frame
	void Update () {
        if (startAnim)
        {
            startAnim = false;
            GetComponent<Animator>().Play(AnimationName);
        }
	}









}
