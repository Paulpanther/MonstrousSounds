using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TriggerGameWon : MonoBehaviour {

	public Text GoodNews;
	// Use this for initialization
	void Start () {
		GoodNews.enabled = false;
	}

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D Other) {
		GoodNews.enabled = true;
		//Debug.Log("HELLO");
	}
}
