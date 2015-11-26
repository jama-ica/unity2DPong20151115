using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlockController : MonoBehaviour {
	
	private List<blockScript> blockList;

	// Use this for initialization
	void Start () {

		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

		this.blockList = new List<blockScript> ();
		for (int i = 0; i < 2; i++) {
			for(int j = 0 ; j < 16 ; j++){
				//var gameObj = GameObject.Find("block");
				//get no active game object
				var gameObj = this.transform.Find("block").gameObject;
				if( gameObj != null){
					blockScript b = gameObj.GetComponent<blockScript>();
					if(b != null){
						b.place( min.x + j*1.0f + 1.0f, max.y - i*1.0f - 1.0f);
						gameObj.SetActive(true);
						Instantiate(gameObj);
						this.blockList.Add(b);
					}
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
