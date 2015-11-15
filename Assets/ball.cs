using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 dir = new Vector2(1.0f,1.0f);		
		GetComponent<Rigidbody2D>().velocity = dir;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
