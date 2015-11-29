﻿using UnityEngine;
using System.Collections;

public class GuiScriptScore : MonoBehaviour {
	
	public Rect rect;
	private GUIStyle style;
	int score;

	// Use this for initialization
	void Start () {
		this.rect = new Rect (Screen.width * 0.8f, 0, 100, 50);
	
		this.style = new GUIStyle();
		this.style.fontSize = 30;   // フォントサイズの変更
		GUIStyleState styleState = new GUIStyleState();
		styleState.textColor = Color.green;
		this.style.normal = styleState;

		this.score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		string text = "score " + this.score;
		GUI.Label(rect, text, this.style);
	}

	public void addScore(int add)
	{
		this.score += add;
	}
}
