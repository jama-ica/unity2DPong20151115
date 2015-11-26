using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	Vector2 prevVec2;

	// Use this for initialization
	void Start () {
		Vector2 dir = new Vector2(3.0f,-3.0f);		
		GetComponent<Rigidbody2D>().velocity = dir;
	}
	
	// Update is called once per frame
	void Update () {
		prevVec2 = GetComponent<Rigidbody2D> ().velocity;

		// 画面左下のワールド座標をビューポートから取得
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		// 画面右上のワールド座標をビューポートから取得
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

		float addX = 0.0f;
		if (min.x > this.transform.position.x) {
			addX = min.x - this.transform.position.x;
		}
		if (this.transform.position.x > max.x) {
			addX = max.x - this.transform.position.x;
		}
		if (0.0f != addX) {
			Vector2 vec2 = transform.position;
			vec2.x += addX;
			transform.position = vec2;
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x * -1.0f, GetComponent<Rigidbody2D>().velocity.y);
		}

		float addY = 0.0f;
		if (min.y > this.transform.position.y) {
			addY = min.y - this.transform.position.y;
		}
		if (this.transform.position.y > max.y) {
			addY = max.y - this.transform.position.y;
		}
		if (0.0f != addY) {
			Vector2 vec2 = transform.position;
			vec2.y += addY;
			transform.position = vec2;
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y * -1.0f);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (0 < coll.contacts.Length) {
			Vector2 f = this.prevVec2; //GetComponent<Rigidbody2D>().velocity;
			GetComponent<Rigidbody2D>().velocity = Vector2.Reflect(f, coll.contacts[0].normal.normalized);
			prevVec2 = GetComponent<Rigidbody2D> ().velocity;
		}
	}	
}
