using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TriggerGameOver : MonoBehaviour {

	public Text BadNews;
	// Use this for initialization
	void Start () {
		BadNews.enabled = false;
	}

	// Update is called once per frame
	void TriggerGO () {
		BadNews.enabled = true;
	}
}
