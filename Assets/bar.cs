using UnityEngine;
using System.Collections;

public class bar : MonoBehaviour {

	float prevMouseX;

	// Use this for initialization
	void Start () {
		prevMouseX = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 vec2 = transform.position;

		float x = Input.GetAxisRaw ("Horizontal");
		vec2.x += x/10.0f;

		float mouseX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
		if (prevMouseX != mouseX) {
			vec2.x = mouseX;
			prevMouseX = mouseX;
		}

		transform.position = vec2;
	}
}
