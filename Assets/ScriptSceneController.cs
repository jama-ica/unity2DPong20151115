using UnityEngine;
using System.Collections;

public class ScriptSceneController : MonoBehaviour {
	
	public Rect rect;
	private GUIStyle style;
	
	// Use this for initialization
	void Start () {
		this.rect = new Rect (Screen.width * 0.35f, Screen.height * 0.5f, 100, 50);
		
		this.style = new GUIStyle();
		this.style.fontSize = 50;   // フォントサイズの変更
		GUIStyleState styleState = new GUIStyleState();
		styleState.textColor = Color.green;
		this.style.normal = styleState;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		GUI.Label(rect, "Game Over", this.style);
	}
}
