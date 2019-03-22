using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour {

	public Text text;
	public bool showMsecs = false;
	
	private float deltaTime = 0.0f;


	public void Update() {
		deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
		float msec = deltaTime * 1000.0f;
		float fps = 1.0f / deltaTime;
		
		if(showMsecs)
			text.text = fps + "." + msec;
		else
			text.text = ((int)fps).ToString();
	}

}
