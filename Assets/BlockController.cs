using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlockController : MonoBehaviour {

	private GameObject src;
	private List<blockScript> blockList;

	// Use this for initialization
	void Start () {

		this.src = this.transform.Find("block").gameObject;

		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

		this.blockList = new List<blockScript> ();
		for (int i = 0; i < 2 ; i++) {
			for(int j = 0 ; j < 16 ; j++){
				//var gameObj = GameObject.Find("block");
				//get no active game object
				GameObject gameObj = Instantiate(this.src);
				blockScript b = gameObj.GetComponent<blockScript>();
				if(b != null){
					gameObj.SetActive(true);
					b.place( min.x + j*1.0f + 1.0f, max.y - i*1.0f - 1.0f);
					this.blockList.Add(b);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
