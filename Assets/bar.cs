using UnityEngine;
using System.Collections;

public class bar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxisRaw ("Horizontal");
		Vector2 vec2 = transform.position;
		vec2.x += x/10.0f;
		transform.position = vec2;
	}
}
