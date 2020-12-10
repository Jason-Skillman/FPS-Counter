using System;
using UnityEngine;

public class FPSCounter : MonoBehaviour {
	
	public static FPSCounter Instance { get; private set; }

	[SerializeField]
	private bool startOn = default;

	[SerializeField]
	private TextAnchor anchor = TextAnchor.UpperLeft;

	[SerializeField]
	private Color color = new Color(0.0f, 1.0f, 0.5f, 1.0f);
	
	private int avgFrameRate;
	private float timePass;
	private float currentFPSFrame;
	
	/// <summary>
	/// Turn on/off the FPS counter.
	/// </summary>
	public bool IsOn { get; set; }

	/// <summary>
	/// The update interval time in seconds.
	/// </summary>
	public float UpdateInterval { get; set; } = 0.5f;

	private void Awake() {
		if(Instance == null) Instance = this;
		else Destroy(gameObject);
	}

	private void Start() {
		IsOn = startOn;
	}

	private void Update() {
		if(!IsOn) return;

		float current = (int)(1f / Time.unscaledDeltaTime);
		avgFrameRate = (int)current;

		timePass += Time.deltaTime;
		if(timePass > UpdateInterval) {
			timePass = 0;
			currentFPSFrame = avgFrameRate;
		}
	}
	
	private void OnGUI() {
		if(!IsOn) return;
		
		int w = Screen.width, h = Screen.height;
 
		GUIStyle style = new GUIStyle();

		int x = 5;
		if(anchor.Equals(TextAnchor.UpperRight) || anchor.Equals(TextAnchor.MiddleRight) || anchor.Equals(TextAnchor.LowerRight))
			x = -x;
 
		Rect rect = new Rect(x, 3, w, h * 2 / 100);
		style.alignment = anchor;
		style.fontSize = h * 2 / 100;
		style.normal.textColor = color;
		
		/*float msec = deltaTime * 1000.0f;
		float fps = 1.0f / deltaTime;
		string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
		GUI.Label(rect, text, style);*/
		
		GUI.Label(rect, "FPS: " + currentFPSFrame, style);
	}

}