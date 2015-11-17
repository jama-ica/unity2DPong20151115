using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 dir = new Vector2(3.0f,-3.0f);		
		GetComponent<Rigidbody2D>().velocity = dir;
	}
	
	// Update is called once per frame
	void Update () {
		// 画面左下のワールド座標をビューポートから取得
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		// 画面右上のワールド座標をビューポートから取得
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

		float addX = 0.0f;
		if (min.x > this.transform.position.x) {
			addX = this.transform.position.x - min.x;
		}
		if (this.transform.position.x > max.x) {
			addX = -1.0f * (max.x - this.transform.position.x);
		}
		if (0.0f != addX) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x * -1.0f + addX,GetComponent<Rigidbody2D>().velocity.y);
		}

		float addY = 0.0f;
		if (min.y > this.transform.position.y) {
			addY = this.transform.position.y - min.y;
		}
		if (this.transform.position.y > max.y) {
			addY = -1.0f * (max.y - this.transform.position.y);
		}
		if (0.0f != addY) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,GetComponent<Rigidbody2D>().velocity.y * -1.0f + addY);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (0 < coll.contacts.Length) {
			GetComponent<Rigidbody2D>().velocity += (coll.contacts[0].normal + coll.contacts[0].normal);
		}
	}	
}
