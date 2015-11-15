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
		// 画面左下のワールド座標をビューポートから取得
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		// 画面右上のワールド座標をビューポートから取得
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

		if (min.x > this.transform.position.x || this.transform.position.x > max.x) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x * -1.0f,GetComponent<Rigidbody2D>().velocity.y);
		}
		if (min.y > this.transform.position.y || this.transform.position.y > max.y) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,GetComponent<Rigidbody2D>().velocity.y*-1.0f);
		}
	}
}
