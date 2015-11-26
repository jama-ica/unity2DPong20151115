using UnityEngine;
using System.Collections;

public class blockScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Destroy (this.gameObject);
	}

	public void place(float x, float y)
	{
		Vector2 vec2 = new Vector2 (x, y);
		transform.position = vec2;
	}
}
